using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RainCheck.Services
{
    public class DarkSkyEnumJsonConverter : StringEnumConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (JsonSerializationException)
            {
                return Activator.CreateInstance(objectType, null);
            }
        }
    }
}
