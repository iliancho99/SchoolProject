using System;
using System.IO;
namespace SchoolProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text = File.ReadAllText("../main.txt");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine (text);
		}
	}
}
