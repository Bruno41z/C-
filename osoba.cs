/*
 * Created by SharpDevelop.
 * User: bbrun
 * Date: 13.12.2023
 * Time: 20:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 //Stwórz klasę Osoba, która będzie miała następujące pola: imie, nazwisko i wiek. Dodaj metody do ustawiania i pobierania wartości dla tych pól.
//ważne do klasy osoba dodaj metodę bmi  oraz pola waga i wzrost
 
using System;

namespace hjd
{
	
	class Osoba {
		private string imie;
		private string nazwisko;
		private int wiek;
		
		public void ustaw_imie(string im) {
			imie=im;
		}
		
		public void ustaw_nazwisko(string naz) {
			nazwisko=naz;
		}
		
		public void ustaw_wiek(int  wi) {
			wiek=wi;
		}
		
		public void wyswietl() {
			Console.WriteLine("{0} {1} {2} lat",imie,nazwisko,wiek);
		}
		
		public double bmi(double waga, double wzrost) {
			double b;
			b=waga/(wzrost*wzrost);
			return b;
		}
	}
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			Osoba osoba1 = new Osoba();
			
			string imie,nazwisko;
			int wiek;
			
			Console.WriteLine("Podaj imie:");
			imie=Console.ReadLine();
			
			Console.WriteLine("Podaj nazwisko:");
			nazwisko=Console.ReadLine();
			
			Console.WriteLine("Podaj wiek:");
			wiek=int.Parse(Console.ReadLine());
			
			double waga,wzrost;
			
			Console.WriteLine("Podaj wzrost w m (np. 1,80):");
			wzrost=double.Parse(Console.ReadLine());
			
			Console.WriteLine("Podaj wagę w kg (np. 100):");
			waga=double.Parse(Console.ReadLine());
			
			
			Console.WriteLine();
			
			osoba1.ustaw_imie(imie);
			osoba1.ustaw_nazwisko(nazwisko);
			osoba1.ustaw_wiek(wiek);
			
			osoba1.wyswietl();
			Console.WriteLine("Twoje BMI wynosi: {0}",Math.Round(osoba1.bmi(waga,wzrost),2));
			
			Console.ReadKey(true);
		}
	}
}