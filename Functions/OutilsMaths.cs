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

    /// <summary>
    /// Permet de retrouver le nombre plus petit et plus grand d'une série de plusieurs nombre à virgule
    /// </summary>
    /// <param name="numbers">double[]</param>
    /// <returns></returns>
    public static (double, double) GetValuesMinMax(params double[] numbers)
    {
      double min = double.MaxValue;
      double max = double.MinValue;

      foreach (double number in numbers)
      {
        if (number > max) max = number;
        if (number < min) min = number;
      }

      return (min, max);
    }

    public static void GetValuesMinMax(out double min, out double max, params double[] numbers)
    {
      min = double.MaxValue;
      max = double.MinValue;
      foreach (double number in numbers)
      {
        if (number > max) max = number;
        if (number < min) min = number;
      }
    }
  }
}