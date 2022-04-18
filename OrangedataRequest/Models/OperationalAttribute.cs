using System.Collections.Generic;
using Newtonsoft.Json;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Операционный реквизит чека
    /// </summary>
    [JsonObject]
    public class OperationalAttribute
    {
        /// <summary>
        /// Дата, время операции, 1273 (Время в виде строки в формате ISO8601)
        /// </summary>
        public string Date { get; set; }
        
        /// <summary>
        /// Идентификатор операции, 1271
        /// </summary>
        public byte Id { get; set; }

        /// <summary>
        /// Данные операции, 1272
        /// </summary>
        public string Value { get; set; }
    }
}
