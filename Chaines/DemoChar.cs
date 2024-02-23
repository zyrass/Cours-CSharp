using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaines
{
  internal class DemoChar
  {

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
       {"\n"} Rappel de la phrase : {"\n"}
       ( {phrase} )
       La phrase contient {phrase.Length} caractères, dont :
          {"\t"}- {nbLettres} lettres, dont {nbMajuscules} majuscules
          {"\t"}- {nbChiffres} chiffres
          {"\t"}- {nbPonctuations} ponctuations
          {"\t"}- {nbEspaces} espaces
          {"\t"}- {nbSymboles} symboles
       """;

      // Afficher le résultat
      Console.WriteLine(resultat);
    }

  }
}

