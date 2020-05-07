namespace OrangedataRequest.Enums
{
    public enum AgentTypeEnum
    {
        /// <summary>
        ///     Банковский платежный агент
        /// </summary>
        BankAgent = 1 << 0,
        /// <summary>
        ///     Банковский платежный субагент
        /// </summary>
        BankSubAgent = 1 << 1,
        /// <summary>
        ///     Платежный агент
        /// </summary>
        PayingAgent = 1 << 2,
        /// <summary>
        ///     Платежный субагент
        /// </summary>
        PayingSubAgent = 1 << 3,
        /// <summary>
        ///     Поверенный
        /// </summary>
        Attorney = 1 << 4,
        /// <summary>
        ///     Комиссионер
        /// </summary>
        Comissioner = 1 << 5,
        /// <summary>
        ///     Иной агент
        /// </summary>
        Other = 1 << 6
    }
}
