using Newtonsoft.Json;
using OrangedataRequest.Enums;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Оплата
    /// </summary>
    [JsonObject]
    public class Payment
    {
        /// <summary>
        ///     Тип оплаты
        /// </summary>
        public PaymentTypeEnum Type { get; set; }

        /// <summary>
        ///     Сумма оплаты
        /// </summary>
        public decimal Amount { get; set; }
    }
}