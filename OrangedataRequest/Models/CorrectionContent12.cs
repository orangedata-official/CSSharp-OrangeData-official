using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OrangedataRequest.Enums;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Содержимое документа
    /// </summary>
    [JsonObject]
    public sealed class CorrectionContent12
    {
        /// <summary>
        ///     Номер версии ФФД, 1209(ФФД 1.2 - 4)
        /// </summary>
        public FfdVersionEnum FfdVersion { get; set; }

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
        ///     Тип коррекции
        /// </summary>
        public CorrectionTypeEnum CorrectionType { get; set; }

        /// <summary>
        ///     Дата документа основания для коррекции
        ///     В данном реквизите время всегда указывать, как 00:00:00
        /// </summary>
        public string CauseDocumentDate { get; set; }

        /// <summary>
        ///     Номер документа основания для коррекции
        /// </summary>
        public string CauseDocumentNumber { get; set; }

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
        ///     Сумма расчета, указанного в чеке (БСО
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

        ///<summary>
        ///     Информация о покупателе (клиенте)
        ///</summary>
        public Dictionary<string, string> CustomerInfo { get; set; }

        /// <summary>
        /// Операционный реквизит чека
        /// </summary>
        public OperationalAttribute OperationalAttribute { get; set; }

        /// <summary>
        /// Отраслевой реквизит чека
        /// </summary>
        public Dictionary<string, string> IndustryAttribute { get; set; }
    }
}