using Newtonsoft.Json;
using OrangedataRequest.Models;

namespace OrangedataRequest.DataService
{
    [JsonObject]
    class RespItemCodeStatus
    {
        /// <summary>
        ///     Идентификатор документа
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Заводской номер устройства пробившего чек
        /// </summary>
        public string DeviceSN { get; set; }

        /// <summary>
        ///     Регистрационный номер устройства пробившего чек
        /// </summary>
        public string DeviceRN { get; set; }

        /// <summary>
        ///     Номер фискального накопителя
        /// </summary>
        public string FSNumber { get; set; }

        /// <summary>
        ///     Время регистрации фискального документа в ФН
        /// </summary>
        public string ProcessedAt { get; set; }

        /// <summary>
        ///     Содержимое документа
        /// </summary>
        public ItemCodeContent Content { get; set; }

        /// <summary>
        ///     Результат проверки
        /// </summary>
        public CheckKMResultBody CheckResult { get; set; }

        /// <summary>
        /// URL для отправки результатов обработки чека POST запросом
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Метаданные запроса
        /// </summary>
        public string Meta { get; set; }
    }
}
