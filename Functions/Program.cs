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

      // Conception d'une méthode permettant d'afficher un messgae de bienvenue avec un prénom ou pas.
      string resultatMessageBienvenueAnonyme = OutilsTexte.getWelcomeMessage();
      Console.WriteLine($"\n{resultatMessageBienvenueAnonyme}");
      string resultatMessageBienvenuePersonnaliseeA = OutilsTexte.getWelcomeMessage("Marjorie");
      Console.WriteLine(resultatMessageBienvenuePersonnaliseeA);
      string resultatMessageBienvenuePersonnaliseeB = OutilsTexte.getWelcomeMessage("Eléaore");
      Console.WriteLine(resultatMessageBienvenuePersonnaliseeB);

      // Conception d'un tuple
      (double x, double y, double z) point = (32.69, 4541.52, 23.01);
      Console.WriteLine($"\n- Point X = {point.x}\n- Point Y = {point.y}\n- Point Z = {point.z}");

      // Test d'un second Tuple (pas sûr de ce que je fais mais ça fonctionne)
      (
        string firstname,
        string lastname,
        int age,
        bool admin
      ) persona = ("Alain", "Guillon", 39, false);
      string isAdmin = persona.admin ? "je suis l'administrateur du site" : "je ne suis pas l'administrateur de ce site";
      Console.WriteLine($"\nJe m'appel {persona.firstname} {persona.lastname.ToUpper()}, j'ai {persona.age} ans et {isAdmin}");

      // Récupération d'un tuple avec un return
      (double min, double max) = OutilsMaths.GetValuesMinMax(69.69, 32, 31, 33, 68.68, 30.99);
      Console.WriteLine($"\n- La valeur minimale est {min}\n- La valeur maximale est {max}");

      // Récupération d'un tuple sans return
      OutilsMaths.GetValuesMinMax(out double mini, out double maxi, 69.69, 32, 31, 33, 68.68, 30.99);
      Console.WriteLine($"\n- La valeur minimale est {mini}\n- La valeur maximale est {maxi}");

      // Utiliser un paramètre en out + return
      bool reponseOK;
      do
      {
        Console.WriteLine("\nSaisissez un nombre compris entre 1 et 10 :");
        string? reponseSaisie = Console.ReadLine();
        reponseOK = int.TryParse(reponseSaisie, out int nombreRecupere) && nombreRecupere >= 1 && nombreRecupere <= 10;
      } while (!reponseOK);



    }
  }
}
