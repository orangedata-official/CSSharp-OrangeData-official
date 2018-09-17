using System.Collections.Generic;
using Newtonsoft.Json;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Данные агента
    /// </summary>
    [JsonObject]
    public class AgentInfo
    {
        /// <summary>
        ///     Телефон оператора перевода
        /// </summary>
        public IEnumerable<string> PaymentTransferOperatorPhoneNumbers { get; set; }

        /// <summary>
        ///     Операция платежного агента
        /// </summary>
        public string PaymentAgentOperation { get; set; }

        /// <summary>
        ///     Телефон платежного агента
        /// </summary>
        public IEnumerable<string> PaymentAgentPhoneNumbers { get; set; }

        /// <summary>
        ///     Телефон оператора по приему платежей
        /// </summary>
        public IEnumerable<string> PaymentOperatorPhoneNumbers { get; set; }

        /// <summary>
        ///    Наименование оператора перевода
        /// </summary>
        public string PaymentOperatorName { get; set; }

        /// <summary>
        ///     Адрес оператора перевода
        /// </summary>
        public string PaymentOperatorAddress { get; set; }

        /// <summary>
        ///     ИНН оператора перевода
        /// </summary>
        public string PaymentOperatorINN { get; set; }
    }
}
