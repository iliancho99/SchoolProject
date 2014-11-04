using System;


public class RunDemo
{
	public void demo(string input)
	{
		switch (input) 
		{
		case "d1":
		case "d2":
			ExchangeVariable ();
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
}


