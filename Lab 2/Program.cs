// See https://aka.ms/new-console-template for more information

using Lab_2;

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie głównego managera
        Manager glownyManager = new Manager("Kazimierz", "Nowak", 15000m);

        // Tworzenie innych managerów
        Manager managerDzialuA = new Manager("Anna", "Rak", 10000m);
        Manager managerDzialuB = new Manager("Ewa", "Baran", 10000m);

        // Tworzenie pracowników
        Worker pracownik1 = new Worker("Jan", "Nowak", 5000m);
        Worker pracownik2 = new Worker("Adrian", "Kowalski", 5000m);
        Worker pracownik3 = new Worker("Jola", "Jagiello", 5000m);

        // Budowanie hierarchii
        managerDzialuA.Add(pracownik1);
        managerDzialuA.Add(pracownik2);
        managerDzialuB.Add(pracownik3);

        glownyManager.Add(managerDzialuA);
        glownyManager.Add(managerDzialuB);

        // Wypisanie hierarchii
        Console.WriteLine("Struktura firmy:");
        glownyManager.wypiszInfo();

        // Wyświetlenie pensji
        Console.WriteLine($"\nMiesięczne zarobki całej firmy: {glownyManager.podajPensje()} zł");
        Console.WriteLine($"Miesięczne zarobki działu A: {managerDzialuA.podajPensje()} zł");
        Console.WriteLine($"Miesięczne zarobki działu B: {managerDzialuB.podajPensje()} zł");

        // Usuwanie pracownika
        Console.WriteLine("\nUsuwanie pracownika Adrian Kowalski.");
        managerDzialuA.Remove("Adrian", "Kowalski");

        // Ponowne wypisanie hierarchii
        Console.WriteLine("\nFirma po usunięciu pracownika:");
        glownyManager.wypiszInfo();
    }
}