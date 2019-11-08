using System;
using System.Collections.Generic;
using System.Text;

namespace WSB
{
	class Login
	{

		public static void checkLogin()
		{
			Console.WriteLine("Podaj login:");
			string login = Console.ReadLine();
			if (DataManager.userExist(login)) {
				Console.WriteLine("Podaj haslo:");
				string haslo = Console.ReadLine();
				if (DataManager.getPassword(login).Equals(haslo))
				{
					Console.WriteLine("Witamy ponownie, " + login);
				} else {
					Console.WriteLine("Blad, zrestartuj aplikacje");
				}
			} else {
				Console.WriteLine("Taki uzytkownik nie istnieje!");
				return;
			}


		}
	}
}
