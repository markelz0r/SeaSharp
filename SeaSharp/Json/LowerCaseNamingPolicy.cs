using System.Text.Json;

namespace SeaSharp;

public class LowerCaseNamingPolicy : JsonNamingPolicy
{
   public override string ConvertName(string name) => name.ToLower();
}