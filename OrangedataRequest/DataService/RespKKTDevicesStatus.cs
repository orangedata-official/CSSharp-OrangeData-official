using Newtonsoft.Json;
using System.Collections.Generic;

namespace OrangedataRequest.DataService
{
    [JsonObject]
    class RespKKTDevicesStatus
    {
        /// <summary>
        ///     Список устройств в группе
        /// </summary>
        public Models.DeviceInfo[] Devices { get; set; }

        /// <summary>
        ///     Массив ошибок обработки запроса
        /// </summary>
        public IEnumerable<string> Errors { get; set; }
    }
}
