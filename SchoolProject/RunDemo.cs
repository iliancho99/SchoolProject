using System;


public class RunDemo
{
	public static void demo(string input)
	{
		switch (input) 
		{
		case "d1":
		case "d2":
			ExchangeVariable();
			break;
		case "d3":
			MaxFromN ();
			break;
		case "d4":
			SumNNums ();
			break;
		}
	}

	public static void ExchangeVariable()
	{
		Console.Write ("a: ");
		int a = int.Parse (Console.ReadLine());
		Console.Write ("b: ");
		int b = int.Parse (Console.ReadLine());
		a = a + b;
		b = a - b;
		a = a - b;
		Console.WriteLine("a = {0} b = {1}", a, b);

	}
	public static void MaxFromN(){
		Console.Write("n: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Въведи число: ");
		int max = int.Parse (Console.ReadLine());
		int a;
		for (int i = 2; i <= n; i++) {
			Console.Write("Въведи число: ");
			a = int.Parse (Console.ReadLine());
			if (a > max) {
				max = a;
			}
		}
		Console.WriteLine ("Максималното число е : {0}",max);
	}
	public static void SumNNums(){
		Console.Write("n: ");
		int n = int.Parse(Console.ReadLine());
		int sum = 0;
		int a;
		for (int i = 1; i <= n; i++) {
			Console.Write("a: ");
			a = int.Parse(Console.ReadLine());
			sum = sum + a;
		}
		Console.WriteLine ("Сумата е : {0}",sum);
	}
}


