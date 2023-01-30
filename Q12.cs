using System;

class Program
{
 public static void Main(string[] args)	
 {
	 Console.WriteLine("value of x:");
	 int x = Convert.ToInt32(Console.ReadLine());

	 Console.WriteLine("Value of n:");
	 int n = Convert.ToInt32(Console.ReadLine());

	 int i = 1;
	 double sum = 0;
	 while (i <= n) {
		 sum += (i/Math.Pow(x, i+1));
		i++;
	 }
 Console.WriteLine("sum: " + sum);
 } 
}
