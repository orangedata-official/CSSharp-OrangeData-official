using Newtonsoft.Json;

namespace OrangedataRequest.DataService
{
    [JsonObject]
    public class ReqAccessStatus
    {
        /// <summary>
        ///     ИНН организации, для которой пробивается чек
        /// </summary>
        public string INN { get; set; }

        /// <summary>
        ///     Группа устройств, с помощью которых будет пробит чек
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        ///     Название ключа
        /// </summary>
        public string Key { get; set; }
    }
}
