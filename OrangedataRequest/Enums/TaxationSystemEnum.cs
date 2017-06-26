namespace OrangedataRequest.Enums
{
    /// <summary>
    ///     Система налогообложения
    /// </summary>
    public enum TaxationSystemEnum
    {
        /// <summary>
        ///     Общая, ОСН
        /// </summary>
        Common,
        /// <summary>
        ///     Упрощенная доход, УСН доход
        /// </summary>
        Simplified,
        /// <summary>
        ///     Упрощенная доход минус расход, УСН доход - расход
        /// </summary>
        SimplifiedMinusOutlay,
        /// <summary>
        ///     Единый налог на вмененный доход, ЕНВД
        /// </summary>
        UnifiedImputedIncome,
        /// <summary>
        ///     Единый сельскохозяйственный налог, ЕСН
        /// </summary>
        UnifiedAgricultural,
        /// <summary>
        ///     Патентная система налогообложения, Патент
        /// </summary>
        Patent
    }
}
