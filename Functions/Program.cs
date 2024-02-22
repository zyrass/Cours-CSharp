namespace Functions
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Chaptitre 3 - LES FONCTIONS");

      // Première fonction
      int resultatNombreDeMots = OutilsTexte.CompterMots("Je suis une super longue chaîne de caractère.");
      Console.WriteLine($"Il y a actuellement {resultatNombreDeMots} mots dans la phrase que je vien d'analyser");

      // Mise en place d'un tableau de plusieurs notes pour tester différentes méthodes
      Console.WriteLine("\nDéfinition d'un tableau avec différentes notes enregistré pour un étudiant\n");
      double[] notesEleve = { 4.75, 18.00, 3.00, 19.75, 20, 16.35, 2.20 };
      
      // Utilisation d'une méthode pour récupérer la note maximal de l'étudiant
      double resultatNotesMax = OutilsMaths.getNoteMaxWithoutParams(notesEleve);
      Console.WriteLine($"La note maximale obtenue par l'étudiant est {resultatNotesMax}");

      // Utilisation d'une méthode pour récupérer la note minimale de l'étudiant
      double resultatNotesMin = OutilsMaths.getNoteMinWithoutParams(notesEleve);
      Console.WriteLine($"La note minimale obtenue par l'étudiant est {resultatNotesMin}\n");

      // Conception d'une liste de différents fruits sans définir de tableau en amont.
      OutilsTexte.getFruitsWithParams("Fraises", "Pommes", "Banannes", "Kiwis", "Poires", "Lichee");

    }
  }
}
