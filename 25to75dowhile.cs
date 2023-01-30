using System;

class Program 
{
	public static void Main(string[] args)
	{
		int a = 0;
		int b = 25;
		
		do {
			a += b;
			b++;
		} while (b <= 75);
		Console.WriteLine(a);
	}
}
