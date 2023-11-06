using System;
using System.Threading;

namespace papierkamiennozyce
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Witamy w naszym programie!!!");
            Thread.Sleep(1500);

            bool grajDalej = true;
            int punktyGracza = 0;
            int punktyKomputera = 0;

            do
            {
                Console.Clear(); 

                Console.WriteLine("Zagrajmy w papier kamień nożyce :)\n");

                string[] wybor_gracz = new string[] { "papier", "kamien", "nozyce" };
                string[] wybor_komputer = new string[] { "papier", "kamien", "nozyce" };

                int wybor;
                bool wynik = false;

                Console.WriteLine("Wybierz przedmiot:\n 1 - Papier\n 2 - Kamień\n 3 - Nożyce");

                while (!wynik)
                {
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out wybor) && wybor >= 1 && wybor <= 3)
                    {
                        wynik = true;
                        string wyborGracza = wybor_gracz[wybor - 1];

                        Random random = new Random();
                        int losowyWyborKomputera = random.Next(0, 3);
                        string wyborKomputera = wybor_komputer[losowyWyborKomputera];

                        Console.WriteLine("Twój wybór: " + wyborGracza);
                        Console.WriteLine("Wybór komputera: " + wyborKomputera);

                        
                        if (wyborGracza == wyborKomputera)
                        {
                            Console.WriteLine("Remis!");
                        }
                        else if ((wyborGracza == "papier" && wyborKomputera == "kamien") ||
                                 (wyborGracza == "kamien" && wyborKomputera == "nozyce") ||
                                 (wyborGracza == "nozyce" && wyborKomputera == "papier"))
                        {
                            Console.WriteLine("Wygrałeś!");
                            punktyGracza++;
                        }
                        else
                        {
                            Console.WriteLine("Komputer wygrał!");
                            punktyKomputera++;
                        }
                    }
                    else
                    {
                        wynik = false;
                        Console.WriteLine("Nieprawidłowy wybór. Wprowadź liczbę od 1 do 3.");
                    }
                }

                Console.WriteLine("Punkty gracza: " + punktyGracza);
                Console.WriteLine("Punkty komputera: " + punktyKomputera);

                Console.Write("Czy chcesz zagrać jeszcze raz? (tak/nie): ");
                string odpowiedz = Console.ReadLine().ToLower();

                while (odpowiedz != "tak" && odpowiedz != "nie")
                {
                    Console.WriteLine("Nieprawidłowa odpowiedź. Wprowadź 'tak' lub 'nie'.");
                    odpowiedz = Console.ReadLine().ToLower();
                }

                if (odpowiedz != "tak")
                {
                    grajDalej = false;
                }
            }
            while (grajDalej);

            Console.Clear(); 
            Console.WriteLine("Dziękujemy za użycien naszego programu :)");
            Thread.Sleep(2000);
            Environment.Exit(0);
            Console.ReadKey(true);
        }
    }
}   