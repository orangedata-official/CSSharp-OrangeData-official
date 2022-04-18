using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OrangedataRequest.Models
{
    [JsonObject]
    public class KMErrorInfo
    {
        /// <summary>
        ///     Номер позиции, начиная с 0
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        ///     Код маркировки, 2000
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        ///     Результат проверки
        /// </summary>
        public CheckKMResultBody CheckResult { get; set; }
    }
}
