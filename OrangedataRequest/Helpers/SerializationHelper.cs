using Newtonsoft.Json;
using System.IO;

namespace OrangedataRequest.Helpers
{
    internal static class SerializationHelper
    {
        public static string Serialize(object obj)
        {
            var resStr = string.Empty;

            var serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            var s = new MemoryStream();
            using (var sw = new StreamWriter(s))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, obj);
                    writer.Flush();
                    resStr = System.Text.Encoding.UTF8.GetString(s.ToArray(), 0, (int)s.Length);
                }
            }
            return resStr;
        }

        public static T Deserealize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
