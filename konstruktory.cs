/*
 * Created by SharpDevelop.
 * User: User
 * Date: 17.01.2024
 * Time: 08:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace hfh
{
	
	class Pracownicy {
		
		private string imie, nazwisko, stanowisko;
		private uint wiek, staz;
		
		public string getImie() {
			return imie;
		}
		
		public string getNazwisko() {
			return nazwisko;
		}
		
		public string getStanowisko() {
			return stanowisko;
		}
		
		public uint getWiek() {
			return wiek;
		}
		
		public uint getStaz() {
			return staz;
		}
		
		public void ustaw(string imie, string nazwisko, string stanowisko, uint wiek, uint staz) {
			this.imie=imie;
			this.nazwisko=nazwisko;
			this.stanowisko=stanowisko;
			this.wiek=wiek;
			this.staz=staz;
		}
		
		public void wypisz() {
			Console.WriteLine("Pracownik {0} {1} w wieku {2}, na stanowisku {3} z latami stażu: {4}",imie,nazwisko,wiek,stanowisko,staz);
		}
		
		public Pracownicy() {
			imie="Ryszard";
			nazwisko="Kaczmarek";
			stanowisko="Nadleśniczy";
			wiek=80;
			staz=55;
			}
		
		public Pracownicy(string imie, string nazwisko, string stanowisko, uint wiek, uint staz) {
			this.imie=imie;
			this.nazwisko=nazwisko;
			this.stanowisko=stanowisko;
			this.wiek=wiek;
			this.staz=staz;
		}
		
		public Pracownicy(Pracownicy p) {
			imie=p.imie;
			nazwisko=p.nazwisko;
			stanowisko=p.stanowisko;
			wiek=p.wiek;
			staz=p.staz;
		}
		
	}
	
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			Pracownicy p1 = new Pracownicy();
			
			
			Console.WriteLine("Test - metoda ustawiająca:");
			p1.ustaw("Bruno","Kaczmarek","programista",18,2);
			p1.wypisz();
			Console.WriteLine();
			
			Console.WriteLine("Test - metody pobierające:");
				string imie = p1.getImie();
				string nazwisko = p1.getNazwisko();
				string stanowisko = p1.getStanowisko();
				uint wiek = p1.getWiek();
				uint staz = p1.getStaz();
				Console.WriteLine("Pracownik {0} {1} w wieku {2}, na stanowisku {3} z latami stażu: {4}",imie,nazwisko,wiek,stanowisko,staz);
			Console.WriteLine();
			
			Console.WriteLine("Test - konstruktor bezparametrowy:");
				
			Pracownicy p2 = new Pracownicy();
			p2.wypisz();
			Console.WriteLine();
			
			Console.WriteLine("Test - konstruktor z parametrami:");
			Pracownicy p3 = new Pracownicy("Jerzy","Omycki","Półkownik",75,50);
			p3.wypisz();
			Console.WriteLine();
			
			Console.WriteLine("Test - konstruktor kopiujący:");
			
			Pracownicy p4 = new Pracownicy(p1);
			p4.wypisz();
			Console.WriteLine();
			
			Console.ReadKey(true);
		}
	}
}