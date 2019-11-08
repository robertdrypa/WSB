using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WSB
{
	class DataManager
	{
		private static Dictionary<string, string> users = new Dictionary<string, string>();
		private static Dictionary<string, string> books = new Dictionary<string, string>();

		public static void init()
		{

			

			using (StreamReader sr = new StreamReader("users.txt"))
			{
				string line = sr.ReadLine();
				while (line != null) {

					//Struktura danych: login;haslo
					string[] args = line.Split(";");
					users.Add(args[0], args[1]);
				}
			}
			using (StreamReader sr = new StreamReader("books.txt"))
			{
				string line = sr.ReadLine();
				while (line != null)
				{

					//Struktura danych: Tytul;Autor
					string[] args = line.Split(";");
					books.Add(args[0], args[1]);
				}
			}
		}

		public static Boolean userExist(string user)
		{
			foreach (var username in users.Keys)
			{
				if (username.Equals(user))
				{
					return true;
				}
			}
			return false;
		}

		public static string getPassword(string user)
		{
			foreach (KeyValuePair<string, string> users in users)
			{
				if (users.Key.Equals(user))
				{
					return users.Value;
				}
			}
			return "Blad";
		}

	}
}
