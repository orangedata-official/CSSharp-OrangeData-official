using OrangedataRequest.DataService;
using System.Threading.Tasks;

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
        public OrangeRequest(string keyPath, string certPath, string certPassword, string apiUrl= "https://apip.orangedata.ru:2443/api/v2")
        {
            _dataService = new ODDataService(keyPath, certPath, certPassword,apiUrl);
        }

        /// <summary>
        ///     Отправка запроса создания чека
        /// </summary>
        /// <param name="check">Чек</param>
        /// <returns></returns>
        public async Task<ODResponse> CreateCheckAsync(ReqCreateCheck check)
        {
            return await _dataService.SendCheckAsync(check);
        }

        /// <summary>
        ///     Отправка запроса состояния чека
        /// </summary>
        /// <param name="INN">ИНН организации, для которой пробивается чек</param>
        /// <param name="documentId">Идентификатор документа, который был указан при его создании</param>
        /// <returns></returns>
        public async Task<ODResponse> GetCheckStateAsync(string INN, string documentId)
        {
            return await _dataService.GetCheckStateAsync(INN, documentId);
        }

        /// <summary>
        ///     Отправка запроса создания чека коррекции
        /// </summary>
        /// <param name="correctionCheck">Чек коррекции</param>
        /// <returns></returns>
        public async Task<ODResponse> CreateCorrectionCheckAsync(ReqCreateCorrectionCheck correctionCheck)
        {
            return await _dataService.CreateCorrectionsCheckAsync(correctionCheck);
        }

        /// <summary>
        ///     Отправка запроса создания чека коррекции ФФД 1.2
        /// </summary>
        /// <param name="correctionCheck">Чек коррекции</param>
        /// <returns></returns>
        public async Task<ODResponse> CreateCorrectionCheckAsync12(ReqCreateCorrectionCheck12 correctionCheck)
        {
            return await _dataService.CreateCorrectionsCheckAsync12(correctionCheck);
        }

        /// <summary>
        ///     Отправка запроса состояния чека коррекции
        /// </summary>
        /// <param name="INN">ИНН организации, для которой пробивается чек</param>
        /// <param name="documentId">Идентификатор документа, который был указан при его создании</param>
        /// <returns></returns>
        public async Task<ODResponse> GetCorrectionCheckStateAsync(string INN, string documentId)
        {
            return await _dataService.GetCorrectionCheckStateAsync(INN, documentId);
        }

        /// <summary>
        ///     Отправка запроса состояния чека коррекции ФФД 1.2
        /// </summary>
        /// <param name="INN">ИНН организации, для которой пробивается чек</param>
        /// <param name="documentId">Идентификатор документа, который был указан при его создании</param>
        /// <returns></returns>
        public async Task<ODResponse> GetCorrectionCheckStateAsync12(string INN, string documentId)
        {
            return await _dataService.GetCorrectionCheckStateAsync12(INN, documentId);
        }

        /// <summary>
        ///     Отправка запроса статус ККТ в группе
        /// </summary>
        /// <param name="INN">ИНН организации, для которой пробивается чек</param>
        /// <param name="groupName">название группы устройств</param>
        /// <returns></returns>
        public async Task<ODResponse> GetKKTDevicesStateAsync(string INN, string groupName)
        {
            return await _dataService.GetKKTDeviceStateAsync(INN, groupName);
        }

        /// <summary>
        ///     Проверка параметров доступа
        /// </summary>
        /// <param name="request">inn - ИНН организации;group - Группа устройств;key - Название ключа</param>
        /// <param name="groupName">название группы устройств</param>
        /// <returns></returns>
        public async Task<ODResponse> GetAccessStateAsync(ReqAccessStatus request)
        {
            return await _dataService.GetAccessStateAsync(request);
        }

        /// <summary>
        ///     Отправка запроса проверки кода маркировки
        /// </summary>
        /// <param name="request">тело запроса</param>
        /// <returns></returns>
        public async Task<ODResponse> CreateItemCodeCheckAsync12(ReqItemCodeCheck request)
        {
            return await _dataService.CreateItemCodeCheckAsync(request);
        }

        /// <summary>
        ///     Отправка запроса состояния проверки кода маркировки
        /// </summary>
        /// <param name="INN">ИНН организации, для которой пробивается чек</param>
        /// <param name="documentId">Идентификатор документа, который был указан при его создании</param>
        /// <returns></returns>
        public async Task<ODResponse> GetItemCodeStateAsync(string INN, string documentId)
        {
            return await _dataService.GetItemCodeStateAsync(INN, documentId);
        }
    }
}
