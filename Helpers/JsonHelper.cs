using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CDCDemo.Helpers;

public static class JsonHelper
{
    // IMPORTANT: In order to keep things in sync, settings should ALWAY be the same from day 1... 
    // Since any change in serialization settings ca cause a different hash to be calculated and thus, 
    // causing false changes detection when doing CDC.
    public static string Serialize<T>(T obj) => JsonConvert.SerializeObject(obj, new JsonSerializerSettings
    {
        Formatting = Formatting.None, // compact mode, spaces are useless
        ContractResolver = new CamelCasePropertyNamesContractResolver()
    });
}
