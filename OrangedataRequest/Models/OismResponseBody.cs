using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OrangedataRequest.Models
{
    [JsonObject]
    public class OismResponseBody
    {
        /// <summary>
        ///     Дата и время запроса, 2114
        /// </summary>
        public string DateTime { get; set; }

        /// <summary>
        ///     Коды обработки запроса, 2105
        /// </summary>
        public byte ResultCode { get; set; }

        /// <summary>
        ///     Тип кода маркировки, 2100
        /// </summary>
        public byte ItemCodeType { get; set; }

        /// <summary>
        ///     Ответ ОИСМ о статусе товара, 2109
        /// </summary>
        public byte OismStatus { get; set; }

        /// <summary>
        ///     Результаты обработки запроса, 2005
        /// </summary>
        public byte ProcessingResults { get; set; }

        /// <summary>
        ///     Идентификатор товара, 2101
        /// </summary>
        public string ItemId { get; set; }
    }
}
