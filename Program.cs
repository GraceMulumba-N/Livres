using Livres;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans Gestion de Livres!");

        Revue revue1 = new Revue("The New Yorker", "Helen Shaw", 2, 234, 2022);
        Revue revue2 = new Revue("The New York Times", "Michael Schulman", 3, 222, 1989);
        Revue revue3 = new Revue("Roman 20-50", "Anne Wattel", 1, 76, 2023);

        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();

        Roman roman1 = new Roman("Je veux que tu m'aimes", "Antoine Rault", 240, "Theatral");
        Roman roman2 = new Roman("La voleuse de livres", "Markus Zusak", 1620, "Historique");
        Roman roman3 = new Roman("Sherlock Holmes", "Arthur Conan Doyle", 316, "Fiction");

        roman1.AfficherDetails();
        roman2.AfficherDetails();
        roman3.AfficherDetails();
    }
}