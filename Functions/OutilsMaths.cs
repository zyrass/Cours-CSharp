using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
  /// <summary>
  /// Classe permettant de définir un certain nombres de méthode qui seront réutilisées dans mon programme.
  /// </summary>
  internal class OutilsMaths
  {

    /// <summary>
    /// Permet de retourner la note maximale d'un étudiant
    /// </summary>
    /// <param name="notes">Tableau de notes (doubles)</param>
    /// <returns></returns>
    public static double getNoteMaxWithoutParams(double[] notes)
    {
      double noteMax = double.MinValue; // Soit 0

      for (int i = 0; i < notes.Length; i++)
      {
        if (notes[i] > noteMax) noteMax = notes[i];
      }

      return noteMax;
    }

    /// <summary>
    /// Permet de retourner la note minimale d'un étudiant
    /// </summary>
    /// <param name="notes">Tableau de notes (doubles)</param>
    /// <returns></returns>
    public static double getNoteMinWithoutParams(double[] notes)
    {
      double noteMin = double.MaxValue;

      for (int i = 0; i < notes.Length; i++)
      {
        if (notes[i] < noteMin) noteMin = notes[i];
      }

      return noteMin;
    }

  }
}
