namespace OrangedataRequest.Enums
{
    /// <summary>
    ///     Предмет расчета
    /// </summary>
    public enum PaymentSubjectTypeEnum
    {
        /// <summary>
        ///     Товар
        /// </summary>
        Product = 1,
        /// <summary>
        ///     Подакцизный товар
        /// </summary>
        Excisable,
        /// <summary>
        ///     Работа
        /// </summary>
        Job,
        /// <summary>
        ///     Услуга
        /// </summary>
        Service,
        /// <summary>
        ///     Ставка азартной игры
        /// </summary>
        GamblingBet,
        /// <summary>
        ///     Выигрыш азартной игры
        /// </summary>
        GamblingGain,
        /// <summary>
        ///     Лотерейный билет
        /// </summary>
        LotteryTicket,
        /// <summary>
        ///     Выигрыш лотереи
        /// </summary>
        LotteryWinnings,
        /// <summary>
        ///     Предоставление РИД
        /// </summary>
        RID,
        /// <summary>
        ///     Платёж
        /// </summary>
        Payment,
        /// <summary>
        ///     Агентское вознаграждение
        /// </summary>
        AgentComission,
        /// <summary>
        ///     Составной предмет расчета
        /// </summary>
        Composite,
        /// <summary>
        ///     Иной предмет расчета
        /// </summary>
        Other,
        /// <summary>
        ///     Имущественное право
        /// </summary>
        PropertyRight,
        /// <summary>
        ///     Внереализационный доход
        /// </summary>
        NonOperatingIncome,
        /// <summary>
        ///     Страховые взносы
        /// </summary>
        InsurancePremiums,
        /// <summary>
        ///     Торговый сбор
        /// </summary>
        TradingFee,
        /// <summary>
        ///     Курортный сбор
        /// </summary>
        ResortFee,
        /// <summary>
        ///     Залог
        /// </summary>
        Pledge
    }
}
