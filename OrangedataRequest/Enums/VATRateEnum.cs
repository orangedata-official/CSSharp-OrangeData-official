namespace OrangedataRequest.Enums
{
    /// <summary>
    ///     Ставка НДС
    /// </summary>
    public enum VATRateEnum
    {
        /// <summary>
        ///     ставка НДС 18%
        /// </summary>
        VAT18 = 1,
        /// <summary>
        ///     ставка НДС 10%
        /// </summary>
        VAT10,
        /// <summary>
        ///     ставка НДС расч. 18/118
        /// </summary>
        VAT118,
        /// <summary>
        ///     ставка НДС расч. 10/110
        /// </summary>
        VAT110,
        /// <summary>
        ///     ставка НДС 0%
        /// </summary>
        VAT0,
        /// <summary>
        ///     НДС не облагается
        /// </summary>
        NONE
    }
}
