using System;
using System.Linq;

public class Kata
{
  public static string PigIt(string str)
  {
    string result = string.Empty;
    var words = str.Split(" ");
        
    foreach (var word in words) {
      var characters = word.ToCharArray();
      var allPunctuation = characters.All(x => !char.IsLetterOrDigit(x));
        
      if (allPunctuation) {
        result += $"{word} ";
      }
      else {
        var firstLetter = word[0];
        var wordWithoutFirstLetter = word.Substring(1);
        result += $"{wordWithoutFirstLetter}{firstLetter}ay ";
      }
    }
    
    return result.Trim();
  }
}