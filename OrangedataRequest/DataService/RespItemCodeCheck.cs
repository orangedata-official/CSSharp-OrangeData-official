using Newtonsoft.Json;
using System.Collections.Generic;

namespace OrangedataRequest.DataService
{
    [JsonObject]
    class RespItemCodeCheck
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
