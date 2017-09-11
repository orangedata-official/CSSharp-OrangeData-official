namespace OrangedataRequest.Enums
{
    /// <summary>
    ///     Способ расчета
    /// </summary>
    public enum PaymentMethodTypeEnum
    {
        /// <summary>
        ///     Предоплата 100%
        /// </summary>
        Prepay = 1,
        /// <summary>
        ///     Частичная предоплата
        /// </summary>
        PartialPrepay,
        /// <summary>
        ///     Аванс
        /// </summary>
        Advance,
        /// <summary>
        ///     Полный расчёт
        /// </summary>
        Full,
        /// <summary>
        ///     Частичный расчёт и кредит
        /// </summary>
        PartialAndCredit,
        /// <summary>
        ///     Передача в кредит
        /// </summary>
        CreditTransfer,
        /// <summary>
        ///     Оплата кредита
        /// </summary>
        CreditPayment
    }
}
