﻿using Newtonsoft.Json;
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
        ///     Признак расчета
        /// </summary>
        public DocTypeEnum Type { get; set; }

        /// <summary>
        ///     Список предметов расчета
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
        
        /// <summary>
        ///     Признак агента. Битовое поле, где номер бита обозначает, что оказывающий услугу покупателю (клиенту) пользователь является
        ///     Кассовый чек(БСО) может содержать реквизиты «признак агента» (тег 1057), только если отчет о регистрации и(или) текущий отчет о перерегистрации содержит реквизит «признак агента» (тег 1057), имеющий значение, идентичное значению реквизита «признак агента» (тег 1057) кассового чека.
        /// </summary>
        public AgentTypeEnum? AgentType { get; set; }

        /// <summary>
        ///     Телефон оператора перевода
        /// </summary>
        public string[] PaymentTransferOperatorPhoneNumbers { get; set; }

        /// <summary>
        ///     Операция платежного агента
        /// </summary>
        public string PaymentAgentOperation { get; set; }

        /// <summary>
        ///     Телефон платежного агента
        /// </summary>
        public string[] PaymentAgentPhoneNumbers { get; set; }

        /// <summary>
        ///     Телефон оператора по приему платежей
        /// </summary>
        public string[] PaymentOperatorPhoneNumbers { get; set; }

        /// <summary>
        ///     Наименование оператора перевода
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

        /// <summary>
        ///     Телефон поставщика
        /// </summary>
        public string[] SupplierPhoneNumbers { get; set; }

        /// <summary>
        ///     Дополнительный реквизит пользователя
        /// </summary>
        public Dictionary<string, string> AdditionalUserAttribute { get; set; }

        /// <summary>
        ///     Дополнительный реквизит чека(БСО)
        /// </summary>
        public string AdditionalAttribute { get; set; }

        /// <summary>
        ///     Номер автомата
        /// </summary>
        public string AutomatNumber { get; set; }

        /// <summary>
        ///     Адрес расчетов
        /// </summary>
        public string SettlementAddress { get; set; }

        /// <summary>
        ///     Место расчетов
        /// </summary>
        public string SettlementPlace { get; set; }

        /// <summary>
        ///     Покупатель (клиент)
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        ///     ИНН покупателя (клиента)
        /// </summary>
        public string CustomerINN { get; set; }
        
        /// <summary>
        /// Кассир, 1021
        /// </summary>
        public string Cashier { get; set; }

        /// <summary>
        /// ИНН кассира, 1203
        /// </summary>
        public string CashierInn { get; set; }

        /// <summary>
        /// Адрес электронной почты отправителя чека, 1117
        /// </summary>
        public string SenderEmail { get; set; }

        /// <summary>
        /// Сумма расчета, указанного в чеке (БСО), 1020.
        /// </summary>
        public decimal TotalSum { get; set; }

        /// <summary>
        /// Сумма НДС чека по ставке 20%, 1102
        /// </summary>
        public decimal Vat1Sum { get; set; }
        
        /// <summary>
        /// Сумма НДС чека по ставке 10%, 1103
        /// </summary>
        public decimal Vat2Sum { get; set; }
        
        /// <summary>
        /// Сумма расчета по чеку с НДС по ставке 0%, 1104
        /// </summary>
        public decimal Vat3Sum { get; set; }
        
        /// <summary>
        /// Сумма расчета по чеку без НДС, 1105
        /// </summary>
        public decimal Vat4Sum { get; set; }
        
        /// <summary>
        /// Сумма НДС чека по расч. ставке 20/120, 1106
        /// </summary>
        public decimal Vat5Sum { get; set; }
        
        /// <summary>
        /// Сумма НДС чека по расч. ставке 10/110, 1107
        /// </summary>
        public decimal Vat6Sum { get; set; }
    }
}
