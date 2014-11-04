using System;
using System.Text.RegularExpressions;

class MainClass
{
	public static void Main (string[] args)
	{
		RunDemo run = new RunDemo();
		WriteSourceCode write = new WriteSourceCode ();
		while (true)
		{
			Console.WriteLine ("Ако искате да видите кода 'c'(на латиница)");
			Console.WriteLine ("Ако  искате да използвате програмата натиснети 'd'(на латиница)");
			Console.WriteLine ("Въведи цифрата на избраната от теб програма и натиснете Enter.");
			Console.WriteLine ("Размяна на две променливе начин-1 = 1");
			Console.WriteLine ("Размяна на две променливе начин-2 = 2");
			string input = Console.ReadLine ();
			if(input[0] == 'd'){
				run.demo (input);
			}else if(input[0] == 'c'){
				write.WriteCode (input);
			}

			Console.ReadKey ();
			Console.Clear();}

	}
}

