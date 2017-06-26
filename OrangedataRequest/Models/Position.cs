using Newtonsoft.Json;
using OrangedataRequest.Enums;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Позиция чека
    /// </summary>
    [JsonObject]
    public class Position
    {
        /// <summary>
        ///     Количество товара
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        ///     Цена товара с учетом всех скидок и наценок
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        ///     Ставка НДС
        /// </summary>
        public VATRateEnum Tax { get; set; }

        /// <summary>
        ///     Текст позиции
        /// </summary>
        public string Text { get; set; }
    }
}