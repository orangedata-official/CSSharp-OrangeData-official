namespace OrangedataRequest.Enums
{
    /// <summary>
    ///     Тип оплаты
    /// </summary>
    public enum PaymentTypeEnum
    {
        /// <summary>
        ///     Cумма по чеку наличными
        /// </summary>
        Cash = 1,
        /// <summary>
        ///     Сумма по чеку электронными
        /// </summary>
        Emoney,
        /// <summary>
        ///     Сумма по чеку предоплатой (зачетом аванса и (или) предыдущих платежей)
        /// </summary>
        Advance = 14,
        /// <summary>
        ///     Сумма по чеку постоплатой (в кредит)
        /// </summary>
        Credit,
        /// <summary>
        ///     Сумма по чеку (БСО) встречным предоставлением
        /// </summary>
        BSO
    }
}
