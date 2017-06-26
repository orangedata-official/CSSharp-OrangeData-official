using Newtonsoft.Json;
using OrangedataRequest.Enums;
using System.Collections.Generic;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Параметры закрытия чека
    /// </summary>
    [JsonObject]
    public sealed class CheckClose
    {
        /// <summary>
        ///     Оплаты
        /// </summary>
        public IEnumerable<Payment> Payments { get; set; }

        /// <summary>
        ///     Система налогообложения
        /// </summary>
        public TaxationSystemEnum TaxationSystem { get; set; }
    }
}