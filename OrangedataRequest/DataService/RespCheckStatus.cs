using Newtonsoft.Json;
using OrangedataRequest.Models;

namespace OrangedataRequest.DataService
{
    [JsonObject]
    public class RespCheckStatus
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
        ///     Наименование ОФД
        /// </summary>
        public string OFDName { get; set; }

        /// <summary>
        ///     Web-сайт ОФД
        /// </summary>
        public string OFDWebsite { get; set; }

        /// <summary>
        ///     Web-сайт ФНС
        /// </summary>
        public string FNSWebsite { get; set; }

        /// <summary>
        ///     ИНН пользователя
        /// </summary>
        public string CompanyINN { get; set; }

        /// <summary>
        ///     Наименование пользователя
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        ///     Номер ФД
        /// </summary>
        public int DocumentNumber { get; set; }

        /// <summary>
        ///     Номер смены
        /// </summary>
        public int ShiftNumber { get; set; }

        /// <summary>
        ///     Номер чека за смену
        /// </summary>
        public int DocumentIndex { get; set; }

        /// <summary>
        ///     Время регистрации фискального документа в ФН
        /// </summary>
        public string ProcessedAt { get; set; }

        /// <summary>
        ///     Содержимое документа
        /// </summary>
        public Content Content { get; set; }

        /// <summary>
        ///     Сдача
        /// </summary>
        public decimal Change { get; set; }

        /// <summary>
        ///     Фискальный признак  
        /// </summary>
        public string FP { get; set; }
    }
}
