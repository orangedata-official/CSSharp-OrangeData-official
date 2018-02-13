using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace OrangedataRequest.Helpers
{
    public static class SecurityExt
    {

        public static XElement ExportToXml(this RSA rsa)
        {
            var args = rsa.ExportParameters(true);
            return new XElement("key",
                new XElement("D", Convert.ToBase64String(args.D)),
                new XElement("DP", Convert.ToBase64String(args.DP)),
                new XElement("DQ", Convert.ToBase64String(args.DQ)),
                new XElement("Exponent", Convert.ToBase64String(args.Exponent)),
                new XElement("InverseQ", Convert.ToBase64String(args.InverseQ)),
                new XElement("Modulus", Convert.ToBase64String(args.Modulus)),
                new XElement("P", Convert.ToBase64String(args.P)),
                new XElement("Q", Convert.ToBase64String(args.Q))
            );
        }

        public static RSA ImportFromXml(this RSA rsa, string node)
        {
            return rsa.ImportFromXml(XElement.Parse(node));
        }

        public static RSA ImportFromXml(this RSA rsa, XElement xNode)
        {
            var d = Convert.FromBase64String(xNode.Element("D").Value);
            var dp = Convert.FromBase64String(xNode.Element("DP").Value);
            var dq = Convert.FromBase64String(xNode.Element("DQ").Value);
            var exp = Convert.FromBase64String(xNode.Element("Exponent").Value);
            var invQ = Convert.FromBase64String(xNode.Element("InverseQ").Value);
            var mod = Convert.FromBase64String(xNode.Element("Modulus").Value);
            var p = Convert.FromBase64String(xNode.Element("P").Value);
            var q = Convert.FromBase64String(xNode.Element("Q").Value);
            rsa.ImportParameters(new RSAParameters {
                D = d,
                DP = dp,
                DQ = dq,
                Exponent = exp,
                InverseQ = invQ,
                Modulus = mod,
                P = p,
                Q = q
            });
            return rsa;
        }

    }
}
