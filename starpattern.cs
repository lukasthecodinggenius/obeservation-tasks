using System;

class Program
{
 public static void Main(string[] args)	
 {
	 int a = 1;
	 for (int b = 5; b >= a; a++)
	 {
		 for (int c = a; c <= b; c++)
		 {
			 Console.Write("*");
		 }
			 	 Console.WriteLine();
	 }
 }
}	
