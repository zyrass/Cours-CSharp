

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("BonjourJ'ai commencé le chapitre 2");
Console.WriteLine("Tu sais comment je m'appel non ?");
// string? prenom = Console.ReadLine();
// Console.WriteLine($"C'était {prenom} en directe de mon ordinateur le {DateTime.Today}");


// Console.ReadKey(); // Permet d'attendre qu'un utilisateur clique sur une touche pour quitter le programme.


// TABLEAU QUI DOIVENT ETRE DEFINIT OBLIGATOIREMENT SUR LE NOMBRE D'ELEMENT
// Stockage des résultats d'un match de tennis
byte?[] scoresJ1 = new byte?[5]; // Tableau Explicite qui ne peut pas être modifier
byte?[] scoresJ2 = { 2, 6, 7, 3, 5 }; // Tableau Implicite qui ne peut pas être modifier

scoresJ1[0] = 6;
scoresJ1[1] = 5;
scoresJ1[2] = 6;
scoresJ1[3] = 7;
scoresJ1[4] = 3;

Console.WriteLine(scoresJ1.Length); // 5

string message = "Je suis une super longue chaine de caractère afin de tester la méthode split";
string[] data = message.Split(" ");

foreach (var elt in data)
{
  Console.WriteLine(elt);  
}

