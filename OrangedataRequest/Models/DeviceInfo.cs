using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OrangedataRequest.Models
{
    [JsonObject]
    class DeviceInfo
    {
        /// <summary>
        ///     Заводской номер устройства
        /// </summary>
        public string DeviceSN { get; set; }

        /// <summary>
        ///     Номер фискального накопителя
        /// </summary>
        public string FsNumber { get; set; }

        /// <summary>
        ///     Наименование ОФД
        /// </summary>
        public string OfdName { get; set; }

        /// <summary>
        ///     Адрес/IP и порт отправки чеков в ОФД
        /// </summary>
        public string OdfAddress { get; set; }

        /// <summary>
        ///     Количество неотправленных документов
        /// </summary>
        public int UnsentDocumentsCount { get; set; }

        /// <summary>
        ///     Дата и время создания первого неотправленного документа
        /// </summary>
        public string FirstUnsentDocumentDate { get; set; }

        /// <summary>
        ///     Общее количество документов в ФН
        /// </summary>
        public int FsDocumentsCount { get; set; }

        /// <summary>
        ///     Срок конца действия ФН
        /// </summary>
        public string FsExpirationDate { get; set; }
    }
}
