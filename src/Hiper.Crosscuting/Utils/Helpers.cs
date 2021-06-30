using Newtonsoft.Json;

namespace Hiper.Crosscuting.Utils
{
    public static class Helpers
    {
        public static string ToJsonString(this object obj)
           => JsonConvert.SerializeObject(obj);

        public static object ToJsonObject(this string str)
            => JsonConvert.DeserializeObject(str);
    }
}
