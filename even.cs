using System;
class even
{
	
	static void Main(string[] args)
	{
		int a;
		Console.WriteLine("Enter a value");
		a=(Convert.ToInt32(Console.ReadLine()));
		
		if(a%2==0)
		{
			
			Console.Write("Even");
		}
		else
		{
			
			Console.Write("Odd");
		}
		
	}
}