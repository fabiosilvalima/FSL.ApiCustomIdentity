using Newtonsoft.Json;

namespace FSL.ApiCustomIdentity.Extensions
{
    public static class StringExtension
    {
        public static T FromJson<T>(
            this string json)
        {
            if (json == null || json.Length == 0)
                return default;

            return JsonConvert.DeserializeObject<T>(
                json, new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
        }

        public static string ToJson<T>(
            this T obj)
        {
            if (obj == null)
            {
                return null;
            }

            return JsonConvert.SerializeObject(obj,
                 new JsonSerializerSettings()
                 {
                     NullValueHandling = NullValueHandling.Ignore
                 });
        }
    }
}
