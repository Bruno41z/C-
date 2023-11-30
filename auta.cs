/*
 * Created by SharpDevelop.
 * User: User
 * Date: 30.11.2023
 * Time: 12:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace asd
{
	

	class Samochod {
		public string marka;
		public string model;
		
		public int moc;
		public int rok_produkcji;
		
		public double przepieg;
		
	}
	
	class Program
	{
		public static List<Samochod> samochody= new List<Samochod>();
		
		public static void dodaj(string marka,string model, int moc, int rok_produkcji, double przebieg) {
			Samochod samochod = new Samochod {
				marka=marka,
				model=model,
				moc=moc,
				rok_produkcji=rok_produkcji,
				przepieg=przebieg
				
			};
			Program.samochody.Add(samochod);
		}
		
		public static void Main(string[] args)
		{
			bool wynik=true;
			while (wynik) {
			
			string marka,model;
			int moc,rok_produkcji;
			double przbieg;
			
			Console.WriteLine("Podaj markę:");
			marka=Console.ReadLine();
			
			Console.WriteLine("");
			
			Console.WriteLine("Podaj model:");
			model=Console.ReadLine();
			
			Console.WriteLine("");
			
			Console.WriteLine("Podaj moc:");
			moc=int.Parse(Console.ReadLine());
			
			Console.WriteLine("");
			
			Console.WriteLine("Podaj rok produkcji:");
			rok_produkcji=int.Parse(Console.ReadLine());
			
			Console.WriteLine("");
			
			Console.WriteLine("Podaj przebieg:");
			przbieg=double.Parse(Console.ReadLine());
			
			Console.WriteLine("");
			
			dodaj(marka,model,moc,rok_produkcji,przbieg);
			
			for (int i=0;i<samochody.Count;i++) {
				Console.WriteLine("model: {0}",samochody[i].model);
				Console.WriteLine("marka: {0}",samochody[i].marka);
				Console.WriteLine("moc: {0}",samochody[i].moc);
				Console.WriteLine("rok produkcji: {0}",samochody[i].rok_produkcji);
				Console.WriteLine("przebieg: {0}",samochody[i].przepieg);
			}
			
			string con;
			Console.WriteLine("Chcesz kontynuować? tak/nie");
			con=Console.ReadLine();
			if (con=="tak") wynik=true; 
			if (con!="tak") wynik=false; Console.WriteLine("Dziękujemy za użycie programu");
			
			}
			
			Console.ReadKey(true);
		}
	}
}