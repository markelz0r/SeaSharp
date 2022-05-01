using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SeaSharp;

public class LowerCaseNamingPolicy : JsonNamingPolicy
{
   public override string ConvertName(string name)
   {
      return PascalCaseToUnderscore(name);
   }

   private string PascalCaseToUnderscore(string name)
   {
      if (string.IsNullOrEmpty(name))
         return name;

      var words = Regex.Split(name, @"(?<!^)(?=[A-Z])");
      var sb = new StringBuilder();
      foreach (var word in words)
      {
         var lowercase = word.ToLower();
         sb.Append(lowercase);
         sb.Append('_');
      }

      // Remove trailing _
      sb.Remove(sb.Length - 1, 1);

      return sb.ToString();
   }
}