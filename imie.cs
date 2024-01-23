
using System;

namespace rtsybyi
{
	class Osoby {
		private string name;
		
		public void SetName(string name) {
			this.name=name;
		}
		
		public void show() {
			Console.WriteLine("Your name: {0}",name);
		}
		
		public bool IsWoman() {
			if (name[name.Length-1]=='a') {
				return true;
			}
			else {
				return false;
			}
		}
		
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Osoby os1 = new Osoby();
			
			string name;
			Console.WriteLine("Give your name:");
			name=Console.ReadLine();
			
			os1.SetName(name);
			os1.show();
			
			if (os1.IsWoman()) {
				Console.WriteLine("You are a Woman");
			}
			else {
				Console.WriteLine("You are a Man");
			}
			
			Console.ReadKey(true);
		}
	}
}