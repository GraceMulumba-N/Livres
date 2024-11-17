using Livres;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans Gestion de Livres!");

        Revue revue1 = new Revue("The New Yorker", "Helen Shaw", 2, 234, 2022);
        Revue revue2 = new Revue("The New York Times", "Michael Schulman", 3, 222, 1989);
        Revue revue3 = new Revue("Roman 20-50", "Anne Wattel", 1, 76, 2023);

        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();
    }
}