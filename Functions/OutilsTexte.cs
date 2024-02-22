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

  }
}
