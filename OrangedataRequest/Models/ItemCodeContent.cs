using Newtonsoft.Json;
using System.Collections.Generic;

namespace OrangedataRequest.Models
{
    [JsonObject]
    public class ItemCodeContent
    {
        /// <summary>
        ///     Планируемый статус, 2003
        /// </summary>
        public byte PlannedStatus { get; set; }

        /// <summary>
        ///     Код маркировки, 2000
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        ///     Мера количества предмета расчета, 2108
        /// </summary>
        public byte QuantityMeasurementUnit { get; set; }

        /// <summary>
        ///     Количество предмета расчета, 1023
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Дробное количество маркированного товара, 1291
        /// </summary>
        public Dictionary<string, ulong> FractionalQuantity { get; set; }
    }
}
