using System;

class Program 
{
	public static void Main(string[] args)
	{
		int c = 0;
		int d = 1;

		while (d<=50) {
			c += d;
			d += 2;
		} 
		Console.WriteLine(c);
	}
}
