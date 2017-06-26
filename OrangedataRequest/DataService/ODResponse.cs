using System.Net;

namespace OrangedataRequest.DataService
{
    /// <summary>
    ///     Ответ сервера
    /// </summary>
    public sealed class ODResponse
    {
        /// <summary>
        ///     Код статуса HTTP
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        ///     Десериализованный ответ
        /// </summary>
        public object ResponseObject { get; set; }

        /// <summary>
        ///     Строка ответа от сервера
        /// </summary>
        public string Response { get; set; }
    }
}
