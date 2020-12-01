﻿using Newtonsoft.Json;
using OrangedataRequest.Models;

namespace OrangedataRequest.DataService
{
    /// <summary>
    ///     Тело запроса
    /// </summary>
    [JsonObject]
    public class ReqCreateCheck
    {
        /// <summary>
        ///     Идентификатор документа
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     ИНН организации, для которой пробивается чек
        /// </summary>
        public string INN { get; set; }

        /// <summary>
        ///     Группа устройств, с помощью которых будет пробит чек
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        ///     Содержимое документа
        /// </summary>
        public Content Content { get; set; }

        /// <summary>
        ///     Название ключа который должен быть использован для проверки подпись. 
        ///     Опциональный параметр. 
        ///     Если имя ключа не указано для проверки подписи будет использован ключ, заданный по умолчанию.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// URL для отправки результатов обработки чека POST запросом
        /// </summary>
        public string CallbackUrl { get; set; }
    }
}