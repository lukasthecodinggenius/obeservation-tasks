using System;

class Program 
{
	public static void Main(string[] args)
	{
		int b = 0;
		int[] arr ={6, 0, 4, 3, 2, 1}; 
		for (int a = 0; a < 6; a++) {
			b += arr[a];
		} 
		Console.WriteLine(b);
	}
}
