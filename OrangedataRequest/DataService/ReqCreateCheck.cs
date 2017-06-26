using Newtonsoft.Json;
using OrangedataRequest.Models;

namespace OrangedataRequest.DataService
{
    /// <summary>
    ///     Тело запроса
    /// </summary>
    [JsonObject]
    public class ReqCreateCheck
    {
        /// <summary>
        ///     Идентификатор документа
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     ИНН организации, для которой пробивается чек
        /// </summary>
        public string INN { get; set; }

        /// <summary>
        ///     Группа устройств, с помощью которых будет пробит чек
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        ///     Содержимое документа
        /// </summary>
        public Content Content { get; set; }
    }
}
