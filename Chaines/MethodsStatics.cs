using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaines
{
  internal class MethodsStatics
  {
    static string s1 = "Un texte";
    static string s2 = "découpé en plusieurs morceaux";
    static string s3 = "pour la démo";

    // Concaténation
    public static void GetConcat()
    {
      string res1 = string.Concat(s1, " ", s2, "\n", s3, " !");
      Console.WriteLine($"Concat :\n{res1}\n");
    }

    // Assemblage en utilisant un séparateur donné
    public static void GetJoin()
    {
      string res1 = string.Join('\n', s1, s2, s3);
      Console.WriteLine($"Join :\n{res1}\n");

      string res2 = string.Join('-', s1, s2, s3);
      Console.WriteLine($"Join :\n{res2}\n");
    }

    // Assemblage via une chaîne de format et des jetons
    public static void GetFormat()
    {
      string res = string.Format("Le {0:dd MMMM} est le {1}ème jour de l'année", DateTime.Today, DateTime.Today.DayOfYear);
      Console.WriteLine($"Format :\n{res}\n");
    }

    // Vérifier si une chaîne est null, vide ou constituée d'espaces blancs
    public static void CheckIsNullOrWhiteSpaceExist()
    {
      string? rep;
      do
      {
        Console.WriteLine("Saisissez votre quelque chose pour tester les espaces blancs ou bien si c'est null :");
        rep = Console.ReadLine();
      }
      while (string.IsNullOrWhiteSpace(rep));
      Console.WriteLine($"Votre message : {rep} !");
    }
  }
}
