using System
class fibo
{
	
	static void Main(string[] args)
	{
		int i;
		int j;
		int a=0;
		int b=1;
		int c=0;
		Console.Write("Enter Max Value");
		j=int.Parse(Console.ReadLine());
		Console.WriteLine(a);
		Console.WriteLine(b);
		for(i=0;i<=j;i++)
		{
			c=a+b;
			Console.WriteLine(c);
			a=b;
			b=c;
		}
		Console.WriteLine();
	}
}