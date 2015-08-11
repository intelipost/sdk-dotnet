using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Intelipost.API.Infrastructure.TimestampToDateTime
{
    public class TimestampToDateTime : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer)
            {
                var ticks = (long)reader.Value;

                var date = new DateTime(1970, 1, 1);
                date = date.AddSeconds(ticks / 1000);

                return date;
            }
            else if (reader.TokenType == JsonToken.Null) {                
                return new DateTime();
            }
            else
            {
                throw new Exception(
                String.Format("Unexpected token parsing date. Expected Integer, got {0}.",
                reader.TokenType));
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is DateTime)
            {
                if (value.ToString() == new DateTime().ToString())
                    writer.WriteValue(String.Empty);
                else
                    writer.WriteValue(value);
            }
            else
            {
                throw new Exception("Expected date object value.");
            }  
        }
    }
}