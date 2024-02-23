using System.Text;

namespace Chaines
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Utilisation de l'unicode au lieu de l'ASCII
      Console.OutputEncoding = new UnicodeEncoding();

      // ---------------------------------------------------------------------------------

      // String
      DemoString.GetInitialString();
      DemoString.GetNewStringWithNumberCharacters();
      DemoString.GetDemo();

      // Special Characters
      Console.WriteLine(SpecialCharacters.chaineDemo);

      // Chaîne Verbatime avec le @""
      Console.WriteLine(DemoChaineVerbatime.demo);

      // Chaîne Littérale brute avec le """
      Console.WriteLine(DemoChaineLitteralBrut.demo);

      // Chaine avec des caractères unicode
      Console.WriteLine(DemoUnicode.listeUnicodeSymboles);
      Console.WriteLine(DemoUnicode.listeUnicodeFlèches);
      Console.WriteLine(DemoUnicode.listeUnicodeSymbolesCodeUnicode);

      // ---------------------------------------------------------------------------------

      // Compter le nombre d'occurence d'une lettre dans un mot
      DemoString.CompterNombreDeLettreDansUnMot("Playstation");
      DemoString.CompterNombreDeLettreDansUnMot("Antituconstitutionnellement", 'e');
      DemoString.CompterNombreDeLettreDansUnMot("Antituconstitutionnellement", 't');
      DemoString.CompterNombreDeLettreDansUnMot("Antituconstitutionnellement", 'u');
      DemoString.CompterNombreDeLettreDansUnMot("Antituconstitutionnellement", 'e');
      DemoString.CompterNombreDeLettreDansUnMot("Antituconstitutionnellement");
      DemoString.CompterNombreDeLettreDansUnMot("infernal", 'n');

      // ---------------------------------------------------------------------------------
      // Méthodes statique
      MethodsStatics.GetConcat();
      MethodsStatics.GetJoin();
      MethodsStatics.GetFormat();
      MethodsStatics.CheckIsNullOrWhiteSpaceExist();

      // ---------------------------------------------------------------------------------
      // Méthodes d'instance

      string chaineDemo = "Je suis une chaîne de caractères.";
      MethodsInstance.CheckContains(chaineDemo, "chaine"); // False
      MethodsInstance.CheckContains(chaineDemo, "chaîne"); // True

      MethodsInstance.CheckStartsWith(chaineDemo, "je"); // False
      MethodsInstance.CheckStartsWith(chaineDemo, "Je"); // True

      MethodsInstance.CheckEndsWith(chaineDemo, "s"); // False
      MethodsInstance.CheckEndsWith(chaineDemo, "."); // True

      MethodsInstance.CheckIndexOf(chaineDemo, "î"); // 15
      MethodsInstance.CheckIndexOf(chaineDemo, "."); // 32

      MethodsInstance.CheckLastIndexOf(chaineDemo, "u"); // 8
      MethodsInstance.CheckLastIndexOf(chaineDemo, "e"); // 30

      MethodsInstance.CheckSubstring(chaineDemo, 10, 10); // e chaîne d
      MethodsInstance.CheckSubstring(chaineDemo, 3, chaineDemo.Length - 3); // suis une chaîne de caractères.

      MethodsInstance.CheckReplace(chaineDemo, "u", "_"); // Je s_uis _ne chaîne de caractères
      MethodsInstance.CheckReplace(chaineDemo, " ", "\n- "); // Voir ci dessous
      /**
       * Je
       * - suis
       * - une
       * - chaîne
       * - de
       * - caractères.
       **/

      MethodsInstance.TransformerEnMinuscule(chaineDemo); // je suis une chaîne de caractères.

      MethodsInstance.TransformerEnMajuscule(chaineDemo); // JE SUIS UNE CHAÎNE DE CARACTÈRES.

      // ---------------------------------------------------------------------------------
      // Dem

      string phrase = """
       Au 30 juin 2022, en France, 51 % des abonnements internet à haut et très haut débit
       étaient en fibre optique (+ 11 points en un an).
       """;
      DemoChar.DecomposerUnePhrase(phrase);


      string wikipedia = """
        16 février : le leader d'opposition et prisonnier politique russe Alexeï Navalny (photo) meurt à la colonie pénitentiaire de Kharp.
        15 février : en Grèce, le Parlement légalise le mariage et l'adoption pour les couples de personnes du même sexe.
        14 février : en Indonésie, Prabowo Subianto remporte l'élection présidentielle, organisée en même temps que celles législatives et locales.
        11 février : Alexander Stubb est élu au second tour président de la république de Finlande.
        10 février : la présidente hongroise Katalin Novák démissionne à l'issue d'une polémique provoquée par la grâce qu'elle a accordée à une personne condamnée pour avoir couvert des actes de pédocriminalité.
        """;
      DemoChar.DecomposerUnePhrase(wikipedia);

    }
  }
}
