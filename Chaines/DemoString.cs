using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaines
{
  internal class DemoString
  {

    static string initialString = "abc";   // syntaxe la plus commune
    static string newStringWithNumberCharacters = new string('*', 69); // N fois le même caractère
    static char[] demo = { 'd', 'e', 'm', 'o' }; // A partir d'un tableau de caractères

    public static void GetInitialString()
    {
      Console.WriteLine(initialString);
      // Résultat : abc
    }

    public static void GetNewStringWithNumberCharacters()
    {
      Console.WriteLine(newStringWithNumberCharacters);
      // Résultat : *********************************************************************
    }

    public static void GetDemo()
    {
      string charDemo = new string(demo);
      Console.WriteLine(charDemo);
      // Résultat : demo
    }

    public static void CompterNombreDeLettreDansUnMot(string mot, char letter = 'a')
    {
      int compteur = 0;
      for (int i = 0; i < mot.Length; i++)
      {
        if (mot[i] == letter) compteur++;
      }
      Console.WriteLine($"- Il y a {compteur} '{letter}' dans '{mot}'");
    }
  }
}
