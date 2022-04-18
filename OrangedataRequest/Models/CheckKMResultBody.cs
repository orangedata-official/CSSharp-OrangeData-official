using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OrangedataRequest.Models
{
    [JsonObject]
    public class CheckKMResultBody
    {
        /// <summary>
        ///     Результат проверки КМ, 2004
        /// </summary>
        public byte FsCheckStatus { get; set; }

        /// <summary>
        ///     Причина, по которой не была проведена локальная проверка
        /// </summary>
        public byte FsCheckStatusCause { get; set; }

        /// <summary>
        ///     Тип кода маркировки, 2100
        /// </summary>
        public byte FsItemCodeType { get; set; }

        /// <summary>
        ///     Результат проверки сведений о товаре, 2106
        /// </summary>
        public byte CheckResult { get; set; }

        /// <summary>
        ///     Код ответа ФН на команду онлайн-проверки
        /// </summary>
        public byte OismCheckResultCode { get; set; }

        /// <summary>
        ///     Код ответа ФН на команду онлайн-проверки
        /// </summary>
        public OismResponseBody OismResponse { get; set; }
    }
}
