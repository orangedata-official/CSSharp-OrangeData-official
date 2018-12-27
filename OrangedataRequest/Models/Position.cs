using System.ComponentModel;
using Newtonsoft.Json;
using OrangedataRequest.Enums;

namespace OrangedataRequest.Models
{
    /// <summary>
    ///     Предмет расчёта
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

        /// <summary>
        ///     Признак способа расчета
        /// </summary>
        [DefaultValue(PaymentMethodTypeEnum.Full)]
        public PaymentMethodTypeEnum PaymentMethodType { get; set; }

        /// <summary>
        ///     Признак предмета расчета
        /// </summary>
        [DefaultValue(PaymentSubjectTypeEnum.Product)]
        public PaymentSubjectTypeEnum PaymentSubjectType { get; set; }

        /// <summary>
        ///     Код товарной номенклатуры
        /// </summary>
        public string NomenclatureCode { get; set; }

        /// <summary>
        ///     Данные поставщика
        /// </summary>
        public SupplierInfo SupplierInfo { get; set; }

        /// <summary>
        ///     ИНН поставщика
        /// </summary>
        public string SupplierINN { get; set; }

        /// <summary>
        ///     Признак агента по предмету расчета
        /// </summary>
        public AgentTypeEnum? AgentType { get; set; }

        /// <summary>
        ///     Данные агента
        /// </summary>
        public AgentInfo AgentInfo { get; set; }

        /// <summary>
        ///     Единица измерения предмета расчета
        /// </summary>
        public string UnitOfMeasurement { get; set; }

        /// <summary>
        ///     Дополнительный реквизит предмета расчета
        /// </summary>
        public string AdditionalAttribute { get; set; }

        /// <summary>
        ///     Код страны происхождения товара
        /// </summary>
        public string ManufacturerCountryCode { get; set; }

        /// <summary>
        ///     Номер таможенной декларации
        /// </summary>
        public string CustomsDeclarationNumber { get; set; }

        /// <summary>
        ///     Акциз
        /// </summary>
        public decimal? Excise { get; set; }
    }
}