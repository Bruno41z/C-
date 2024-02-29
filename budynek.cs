using System;

namespace ubrgou
{
    class Budynek 
    {
        private string adres;
        private double powierzchnia;
        private uint ilosc_kondygnacji;

        public void wypisz() 
        {
            if (ilosc_kondygnacji == 1) 
            {
                Console.WriteLine("Budynek jest parterowy");
            }
            else 
            {
                Console.WriteLine("Budynek jest {0} piętrowy", ilosc_kondygnacji);
            }

            Console.WriteLine("Adres: {0}", adres);
            Console.WriteLine("Powierzchnia wynosi: {0}m^2", powierzchnia);
            Console.WriteLine("Powierzchnia użytkowa wynosi: {0}m^2", pow_uzy());
        }

        public Budynek(string adres, double powierzchnia, uint ilosc_kondygnacji) 
        {
            this.adres = adres;
            this.powierzchnia = powierzchnia;
            this.ilosc_kondygnacji = ilosc_kondygnacji;
        }
        
        public double pow_uzy() {
        	return powierzchnia*ilosc_kondygnacji;
        }
        
    }

    class BudynekMieszkalny : Budynek 
    {
        uint ile_mieszkan;

        public void wypiszBM() 
        {
            Console.WriteLine("Ilość mieszkań w budynku: {0}", ile_mieszkan);
            Console.WriteLine("Średnia powierzchania mieszkania: {0}", pow_uzy() / ile_mieszkan);
        }

        public void wypiszALL() 
        {
            wypisz();
            wypiszBM();
        }

        public BudynekMieszkalny(string adres, double powierzchnia, uint ile_kondygnacji, uint ile_mieszkan) : base(adres, powierzchnia, ile_kondygnacji) 
        {
            this.ile_mieszkan = ile_mieszkan;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Budynek b1 = new Budynek("Dopiewo Leśna 60a", 250, 2);
            b1.wypisz();
			
            BudynekMieszkalny b2 = new BudynekMieszkalny("Warszawa Umińskiego 17b",100,1,4);
            b2.wypiszALL();
            
            
            Console.ReadKey(true);
        }
    }
}
