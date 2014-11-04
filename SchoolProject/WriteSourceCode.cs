using System;


public class WriteSourceCode
{
	public void WriteCode (string input)
	{
		string text = "Няма такъв код";
		switch (input) {
		case "c1":
			text = System.IO.File.ReadAllText ("C-Codes/Razmqna-na-dve promenlivi-1.txt");
			break;
		case "c2":
			text = System.IO.File.ReadAllText ("C-Codes/Razmqna-na-dve-promenlivi-2.txt");
			break;
		default:
			break;
		}
		Console.WriteLine (text);
	}
}


