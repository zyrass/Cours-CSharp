using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaines
{
  internal class MethodsInstance
  {

    public static void CheckContains(string chaine, string mot)
    {
      Console.WriteLine(chaine.Contains(mot));
    }

    public static void CheckStartsWith(string phrase, string terme)
    {
      Console.WriteLine(phrase.StartsWith(terme));
    }

    public static void CheckEndsWith(string phrase, string terme)
    {
      Console.WriteLine(phrase.EndsWith(terme));
    }

    public static void CheckIndexOf(string phrase, string terme)
    {
      Console.WriteLine(phrase.IndexOf(terme));
    }

    public static void CheckLastIndexOf(string phrase, string terme)
    {
      Console.WriteLine(phrase.LastIndexOf(terme));
    }

    public static void CheckSubstring(string phrase, int startIndex, int combienCaractères)
    {
      Console.WriteLine(phrase.Substring(startIndex, combienCaractères));
    }

    public static void CheckReplace(string phrase, string quelCaractere, string parQuelCaractere)
    {
      Console.WriteLine(phrase.Replace(quelCaractere, parQuelCaractere));
    }

    public static void TransformerEnMinuscule(string phrase)
    {
      Console.WriteLine(phrase.ToLower());
    }

    public static void TransformerEnMajuscule(string phrase)
    {
      Console.WriteLine(phrase.ToUpper());
    }

  }
}
