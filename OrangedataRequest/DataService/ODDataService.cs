using OrangedataRequest.Helpers;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OrangedataRequest.DataService
{
    internal sealed class ODDataService
    {
        public ODDataService(string keyPath, string certPath, string certPassword,
            string apiUrl)
        {
            _keyPath = keyPath;
            _cert = new X509Certificate2(certPath, certPassword);
            _apiUrl = apiUrl;
        }

        private string _apiUrl = "https://46.28.89.45:2443/api/v2";

        private readonly string _keyPath;
        private readonly X509Certificate2 _cert;
        private readonly Encoding _encoding = Encoding.UTF8;

        #region Public methods

        public ODResponse SendCheck(ReqCreateCheck check)
        {
            var requestBody = SerializationHelper.Serialize(check);
            var signature = ComputeSignature(requestBody);

            return SendRequest<RespCreateCheck>($"{_apiUrl}/documents", "POST", requestBody, signature);
        }

        public ODResponse CreateCorrectionsCheck(ReqCreateCorrectionCheck correctionCheck)
        {
            var requestBody = SerializationHelper.Serialize(correctionCheck);
            var signature = ComputeSignature(requestBody);

            return SendRequest<RespCreateCheck>($"{_apiUrl}/corrections", "POST", requestBody, signature);
        }

        public ODResponse GetCheckState(string INN, string documentId)
        {
            return SendRequest<RespCheckStatus>($"{_apiUrl}/documents/{INN}/status/{documentId}", "GET");
        }

        public ODResponse GetCorrectionCheckState(string INN, string documentId)
        {
            return SendRequest<RespCheckStatus>($"{_apiUrl}/corrections/{INN}/status/{documentId}", "GET");
        }

        #endregion Public methods

        #region Helpers

        private ODResponse SendRequest<T>(string uri, string method, string requestBody = null, string signature = null)
        {
            if (string.IsNullOrEmpty(uri))
            {
                throw new ArgumentNullException(nameof(uri));
            }
            if (string.IsNullOrEmpty(method))
            {
                throw new ArgumentNullException(nameof(method));
            }

            var httpRequest = WebRequest.CreateHttp(uri);

            if (!string.IsNullOrWhiteSpace(signature))
            {
                httpRequest.Headers["X-Signature"] = signature;
            }
            httpRequest.KeepAlive = true;
            httpRequest.UserAgent = "OrangeDataClient";
            httpRequest.Method = method;
            httpRequest.ContentType = "application/json; charset=utf-8";
            httpRequest.ClientCertificates.Add(_cert);
            httpRequest.PreAuthenticate = true;
            ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => true;

            HttpWebResponse httpResponse;
            if (!string.IsNullOrEmpty(requestBody))
            {
                var buf = _encoding.GetBytes(requestBody);
                httpRequest.ContentLength = buf.Length;
                using (Stream requestStream = httpRequest.GetRequestStream())
                {
                    requestStream.Write(buf, 0, buf.Length);
                }
            }

            try
            {
                httpResponse = httpRequest.GetResponse() as HttpWebResponse;
            }
            catch (WebException webException)
            {
                httpResponse = (HttpWebResponse)webException.Response;
            }

            return ExtractResponse<T>(httpResponse);
        }

        private ODResponse ExtractResponse<T>(HttpWebResponse response)
        {
            var res = new ODResponse();
            using (response)
            {
                res.StatusCode = response.StatusCode;
                using (Stream data = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(data))
                    {
                        string text = reader.ReadToEnd();
                        try
                        {
                            res.ResponseObject = SerializationHelper.Deserealize<T>(text);
                        }
                        finally
                        {
                            res.Response = text;
                        }
                    }
                }
            }
            return res;
        }

        private string ComputeSignature(string document)
        {
            var data = Encoding.UTF8.GetBytes(document);

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(File.ReadAllText(_keyPath));
                return Convert.ToBase64String(rsa.SignData(data, "SHA256"));
            }
        }

        #endregion Helpers
    }
}
