using System;
using Newtonsoft.Json;
using OrangedataRequest.Enums;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Содержимое документа
    /// </summary>
    [JsonObject]
    public sealed class CorrectionContent
    {
        /// <summary>
        ///     Тип коррекции
        /// </summary>
        public CorrectionTypeEnum CorrectionType { get; set; }

        /// <summary>
        ///     Признак расчета
        /// </summary>
        public DocTypeEnum Type { get; set; }

        /// <summary>
        ///     Описание коррекции
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Дата документа основания для коррекции
        ///     В данном реквизите время всегда указывать, как 00:00:00
        /// </summary>
        public DateTime CauseDocumentDate { get; set; }

        /// <summary>
        ///     Номер документа основания для коррекции
        /// </summary>
        public string CauseDocumentNumber { get; set; }

        /// <summary>
        ///     Сумма расчета, указанного в чеке (БСО
        /// </summary>
        public decimal TotalSum { get; set; }

        /// <summary>
        ///     Сумма по чеку (БСО) наличными
        /// </summary>
        public decimal CashSum { get; set; }

        /// <summary>
        ///     Сумма по чеку (БСО) электронными
        /// </summary>
        public decimal ECashSum { get; set; }

        /// <summary>
        ///     Сумма по чеку (БСО) предоплатой (зачетом аванса и (или) предыдущих платежей)
        /// </summary>
        public decimal PrepaymentSum { get; set; }

        /// <summary>
        ///     Сумма по чеку (БСО) постоплатой (в кредит)
        /// </summary>
        public decimal PostpaymentSum { get; set; }

        /// <summary>
        ///     Сумма по чеку (БСО) встречным предоставлением
        /// </summary>
        public decimal OtherPaymentTypeSum { get; set; }

        /// <summary>
        ///     Сумма НДС чека по ставке 18%
        /// </summary>
        public decimal Tax1Sum { get; set; }

        /// <summary>
        ///     Сумма НДС чека по ставке 10%
        /// </summary>
        public decimal Tax2Sum { get; set; }

        /// <summary>
        ///     Сумма расчета по чеку с НДС по ставке 0%
        /// </summary>
        public decimal Tax3Sum { get; set; }

        /// <summary>
        ///     Сумма расчета по чеку без НДС
        /// </summary>
        public decimal Tax4Sum { get; set; }

        /// <summary>
        ///     Сумма НДС чека по расч. ставке 18/118
        /// </summary>
        public decimal Tax5Sum { get; set; }

        /// <summary>
        ///     Сумма НДС чека по расч. ставке 10/110
        /// </summary>
        public decimal Tax6Sum { get; set; }

        /// <summary>
        ///     Применяемая система налогообложения
        /// </summary>
        public TaxationSystemEnum TaxationSystem { get; set; }
    }
}