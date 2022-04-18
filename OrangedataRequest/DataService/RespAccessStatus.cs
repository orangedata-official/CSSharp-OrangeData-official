using System.Collections.Generic;
using Newtonsoft.Json;

namespace OrangedataRequest.DataService
{
    [JsonObject]
    public class RespAccessStatus
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
