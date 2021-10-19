using System;
					
public class Program
{
	public static void Main()
	{
        // Definicion de variables 
		int a = 22;
		int b = 6;
		int c = 3;
		
		// Cuando se necesita la combinacion: aacb
		Console.Write(a);
		Console.Write(a);
		Console.Write(c);
		Console.WriteLine(b);
		
		Console.WriteLine("----");
		
		// Cuando se necesita la combinacion: bca
		Console.Write(b);
		Console.Write(c);
		Console.WriteLine(a);
		
		Console.WriteLine("----");

		// Cuando se necesita la combinacion: bcbc
		Console.Write(b);
		Console.Write(c);
		Console.Write(b);
		Console.WriteLine(c);
		
		
	}
}