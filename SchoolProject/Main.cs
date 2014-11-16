using System;
using System.Text.RegularExpressions;

class MainClass
{
	public static void Main (string[] args)
	{
		while (true)
		{
			Console.WriteLine ("Ако искате да видите кода 'c'(на латиница)");
			Console.WriteLine ("Ако  искате да използвате програмата натиснети 'd'(на латиница)");
			Console.WriteLine ("Въведи цифрата на избраната от теб програма и натиснете Enter.");
			Console.WriteLine ("Размяна на две променливе начин-1 = 1");
			Console.WriteLine ("Размяна на две променливе начин-2 = 2");
			Console.WriteLine ("Максималното от n числа = 3");
			Console.WriteLine ("Сумата на n числа = 4");
			string input = Console.ReadLine ();
			if(input[0] == 'd'){
				RunDemo.demo(input);
			}else if(input[0] == 'c'){
				WriteSourceCode.WriteCode (input);
			}

			Console.ReadKey ();
			Console.Clear();
		}
	}
}

