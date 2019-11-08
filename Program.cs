using System;

namespace WSB
{
	class Program
	{
		static void Main(string[] args)
		{
			DataManager.init();
			Console.WriteLine("MENU:");
	
			Console.WriteLine("1. Zaloguj.");
			string x = Console.ReadLine();
			switch (x)
			{
				case "1": {
						Login.checkLogin();
						break; }
				case "2": { break; }
				case "3": { break; }
				case "4": { break; }
				case "5": { break; }


			}
		}
	} 
}
