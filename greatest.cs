using System
class greatest
{
	
	static void Main(string[] args)
	{
		int a,b,c;
		Console.Write("1st Value");
		a=(convert.ToInt32(Console.ReadLine()));
		Console.Write("2nd Value");
		b=(convert.ToInt32(Console.ReadLine()));
		Console.Write("3rd Value");
		c=(convert.ToInt32(Console.ReadLine()));
		if(a>b && a>c)
		{
			
			Console.Write(a+"is greater than"+b+"and"+c);
		}
		else if(b>c && b>a)
		{
			
			Console.Write(b+"is greater than"+c+"and"+a);
		}
		else
		{
			
			Console.Write(c+"is greater than"+a"and"+b);
		}
	}
}