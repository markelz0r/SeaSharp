using System.Text.Json;
using System.Text.Json.Serialization;

namespace SeaSharp.Json.Converters;

public class StringDecimalJsonConverter : JsonConverter<decimal>
{
   public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
   {
      switch (reader.TokenType)
      {
         case JsonTokenType.Number:
            return reader.GetDecimal();
         case JsonTokenType.String:
            return decimal.Parse(reader.GetString());
         case JsonTokenType.None:
         case JsonTokenType.StartObject:
         case JsonTokenType.EndObject:
         case JsonTokenType.StartArray:
         case JsonTokenType.EndArray:
         case JsonTokenType.PropertyName:
         case JsonTokenType.Comment:
         case JsonTokenType.True:
         case JsonTokenType.False:
         case JsonTokenType.Null:
         default:
            throw new ArgumentOutOfRangeException();
      }
   }

   public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
   {
      throw new NotImplementedException();
   }
}