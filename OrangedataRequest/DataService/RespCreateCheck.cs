using Newtonsoft.Json;
using System.Collections.Generic;

namespace OrangedataRequest.DataService
{
    [JsonObject]
    public class RespCreateCheck
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
