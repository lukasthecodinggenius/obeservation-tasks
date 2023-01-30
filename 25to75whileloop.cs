using System;

class Program 
{
	public static void Main(string[] args)
	{
		int c = 0;
		int d = 25;

		while (d<=75) {
			c += d;
			d++;
		} 
		Console.WriteLine(c);
	}
}
