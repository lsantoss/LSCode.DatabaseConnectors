using Newtonsoft.Json;

namespace LSCode.DatabaseConnectors.Test.Tools.Extensions
{
    public static class JsonFormatter
    {
        public static string ToJson(this string json)
        {
            if (json == null)
                return null;

            var obj = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}