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

    /// <summary>
    /// Affiche un message de bienvenue avec la possibilité de passé un prénom auquel cas un message générque sera affiché.
    /// </summary>
    /// <param name="firstname">Le prénom</param>
    /// <returns></returns>
    public static string getWelcomeMessage(string? firstname = null)
    {
      string message;

      if (firstname == null) message = "Bonjour, bienvenue sur la formation sur C# !";
      else message = $"Bonjour {firstname}, bienvenue sur la formation sur C#";

      return message;
    }

    static string phrase = """
     Au 30 juin 2022, en France, 51 % des abonnements internet à haut et très haut débit
     étaient en fibre optique (+ 11 points en un an).
     """;

    public static void DecomposerUnePhrase(string phrase)
    {
      int nbLettres = 0, nbChiffres = 0, nbPonctuations = 0, nbEspaces = 0, nbSymboles = 0;
      int nbMajuscules = 0;

      foreach (char character in phrase.ToCharArray())
      {
        if (char.IsLetter(character)) nbLettres++;
        else if (char.IsDigit(character)) nbChiffres++;
        else if (char.IsPunctuation(character)) nbPonctuations++;
        else if (char.IsWhiteSpace(character)) nbEspaces++;
        else if (char.IsSymbol(character)) nbSymboles++;

        if (char.IsUpper(character)) nbMajuscules++;

      }

      string resultat = $"""
       La phrase contient {phrase.Length} caractères, dont :{"\n"}
          - {nbLettres} lettres, dont {nbMajuscules} majuscules
          - {nbChiffres} chiffres
          - {nbPonctuations} ponctuations
          - {nbEspaces} espaces
          - {nbSymboles} symboles
       """;

      // Afficher le résultat
      Console.WriteLine(resultat);
    }
  }
}
