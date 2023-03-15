class Calculator
{
	static void Main(string[] args)
	{
		int a = 12;
		int b = 5;
		
		Console.Write("Hasil Penambahan: {0} + {1}", a, b, Penambahan(a, b));
		Console.Write("Hasil Pengurangan} + {1}", a, b, Penguranga (a, b));
		
		Console.Write("\nTekan Sembarang Key untuk keluar");
		Console.Readkey();
		
	}
	
	static int Penambahan (int a, int b)
	{
		return a + b;
	}	
	
	static int Pengurangan (int a, int b)
	{
		return a - b;
	}	
}