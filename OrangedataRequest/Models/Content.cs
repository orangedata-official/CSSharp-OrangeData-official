using Newtonsoft.Json;
using OrangedataRequest.Enums;
using System.Collections.Generic;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Содержимое документа
    /// </summary>
    [JsonObject]
    public sealed class Content
    {
        /// <summary>
        ///     Тип документа
        /// </summary>
        public DocTypeEnum Type { get; set; }

        /// <summary>
        ///     Список позиций в чеке
        /// </summary>
        public IEnumerable<Position> Positions { get; set; }

        /// <summary>
        ///     Параметры закрытия чека
        /// </summary>
        public CheckClose CheckClose { get; set; }

        /// <summary>
        ///     Телефон или e-mail покупателя
        /// </summary>
        public string CustomerContact { get; set; }
    }
}