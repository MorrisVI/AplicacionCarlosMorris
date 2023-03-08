using System;

namespace App_1_xd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
		Console.WriteLine("valor 1 suma");
		string value1 = Console.ReadLine();
		int value1Number = Int32.Parse(value1);
		   
		Console.WriteLine("valor 2 suma");
		string value2 = Console.ReadLine();
		int value2Number = Int32.Parse(value2);
		   
	    Console.WriteLine(value1Number + value2Number);
	   
		Console.WriteLine("valor 1 para restar");
		string value3 = Console.ReadLine();
		int value3Number = Int32.Parse(value3);
	    
		Console.WriteLine("Valor 2 para restar");
		string value4 = Console.ReadLine();
		int value4Number = Int32.Parse(value4);
	   
	    Console.WriteLine(value3Number - value4Number); 
	   
		Console.WriteLine("Valor 1 multiplicacion");
		string value5 = Console.ReadLine();
		int value5Number = Int32.Parse(value5);
	    
		Console.WriteLine("Valor 2 multiplicacion");
		string value6 = Console.ReadLine();
		int value6Number = Int32.Parse(value6);
	   
	    Console.WriteLine(value5Number * value6Number); 
	   
		Console.WriteLine("Valor 1 division");
		string value7 = Console.ReadLine();
		int value7Number = Int32.Parse(value7);
	    
		Console.WriteLine("Valor 2 division");
		string value8 = Console.ReadLine();
		int value8Number = Int32.Parse(value8);
	   
	    Console.WriteLine(value7Number / value8Number);
   }
}
}

