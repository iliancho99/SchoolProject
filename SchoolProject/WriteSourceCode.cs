using System;


public class WriteSourceCode
{
	public static void WriteCode (string input)
	{
		string text = "Няма такъв код";
		switch (input) {
		case "c1":
			text = System.IO.File.ReadAllText ("C-Codes/Razmqna-na-dve promenlivi-1.txt");
			break;
		case "c2":
			text = System.IO.File.ReadAllText ("C-Codes/Razmqna-na-dve-promenlivi-2.txt");
			break;
		case "c3":
			text = System.IO.File.ReadAllText("C-Codes/Max-ot-n-chisla.txt");
			break;
		case "c4":
			text = System.IO.File.ReadAllText ("C-Codes/Sum-ot-n-chisla.txt");
			break;
        case "c5":
            text = System.IO.File.ReadAllText("C-Codes/Sumata-ot-cifrite-na-chislo.txt");
            break;
		}
		Console.WriteLine (text);
	}
}


