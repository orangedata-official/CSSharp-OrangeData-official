using OrangedataRequest.DataService;

namespace OrangedataRequest
{
    public sealed class OrangeRequest
    {
        private readonly ODDataService _dataService;

        /// <summary>
        /// </summary>
        /// <param name="keyPath">Путь к xml-файлу ключа для подписи клиентских сообщений</param>
        /// <param name="certPath">Путь к клиентскому сертификату</param>
        /// <param name="certPassword">Пароль клиентского сертификата</param>
        public OrangeRequest(string keyPath, string certPath, string certPassword)
        {
            _dataService = new ODDataService(keyPath, certPath, certPassword);
        }

        /// <summary>
        ///     Отправка запроса создания чека
        /// </summary>
        /// <param name="check">Чек</param>
        /// <returns></returns>
        public ODResponse CreateCheck(ReqCreateCheck check)
        {
            return _dataService.SendCheck(check);
        }

        /// <summary>
        ///     Отправка запроса состояния чека
        /// </summary>
        /// <param name="INN">ИНН организации, для которой пробивается чек</param>
        /// <param name="documentId">Идентификатор документа, который был указан при его создании</param>
        /// <returns></returns>
        public ODResponse GetCheckState(string INN, string documentId)
        {
            return _dataService.GetCheckState(INN, documentId);
        }

        /// <summary>
        ///     Отправка запроса создания чека коррекции
        /// </summary>
        /// <param name="correctionCheck">Чек коррекции</param>
        /// <returns></returns>
        public ODResponse CreateCorrectionCheck(ReqCreateCorrectionCheck correctionCheck)
        {
            return _dataService.CreateCorrectionsCheck(correctionCheck);
        }

        /// <summary>
        ///     Отправка запроса состояния чека коррекции
        /// </summary>
        /// <param name="INN">ИНН организации, для которой пробивается чек</param>
        /// <param name="documentId">Идентификатор документа, который был указан при его создании</param>
        /// <returns></returns>
        public ODResponse GetCorrectionCheckState(string INN, string documentId)
        {
            return _dataService.GetCorrectionCheckState(INN, documentId);
        }
    }
}
