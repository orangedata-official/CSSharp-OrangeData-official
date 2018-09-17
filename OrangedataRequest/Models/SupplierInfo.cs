using System.Collections.Generic;
using Newtonsoft.Json;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Данные поставщика
    /// </summary>
    [JsonObject]
    public class SupplierInfo
    {
        /// <summary>
        ///     Телефон поставщика
        /// </summary>
        public IEnumerable<string> PhoneNumbers { get; set; }

        /// <summary>
        ///     Наименование поставщика
        /// </summary>
        public string Name { get; set; }

        public void Deconstruct(out IEnumerable<string> phoneNumbers, out string name)
        {
            name = Name;
            phoneNumbers = PhoneNumbers;
        }
    }
}
