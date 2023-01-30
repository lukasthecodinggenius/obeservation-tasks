using System;

class Program 
{
	public static void Main(string[] args)
	{
		int a = 0;
		int b = 1;
		
		do {
			a += b;
			b++;
		} while (b <= 50);
		Console.WriteLine(a);
	}
}
