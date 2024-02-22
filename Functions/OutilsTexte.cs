using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
  /// <summary>
  /// Classe permettant de définir un certain nombre de méthodes qui seront réutilisées dans mon programme.
  /// </summary>
  internal class OutilsTexte
  {

    /// <summary>
    /// Permet de compter le nombre de mots dans une phrase
    /// </summary>
    /// <param name="phrase">Une chaîne de caractère</param>
    /// <returns></returns>
    public static int CompterMots(string phrase)
    {
      int nbMots = 0;
      for (int i = 0; i < phrase.Length; i++)
      {
        // On compte simplement les espaces, les apostropjes et les tabulations
        if (phrase[i] == ' ' || phrase[i] == '\'' || phrase[i] == '\t')
        {
          nbMots++;
        }
      }
      return nbMots++;
    }

    /// <summary>
    /// Permet d'afficher une liste de fruits avec une quantitée indéfinis de paramètres
    /// </summary>
    /// <param name="fruits">Une liste de fruit</param>
    public static void getFruitsWithParams(params string[] fruits)
    {
      Console.WriteLine("Une liste de fruit:\n");
      for (int i = 0; i < fruits.Length; i++)
      {
        Console.WriteLine($"- {fruits[i]}");
      }
    }

  }
}
