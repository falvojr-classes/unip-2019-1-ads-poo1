using System;
					
public class Exercicio06
{
	public static void Main()
	{
		double saldo = 1000000.004;
		if (saldo < 0) {
			Console.WriteLine("Você está no vermelho");
		} else if (saldo < 1000000) {
			Console.WriteLine("Você está no azul");
		} else {
			Console.WriteLine("Você está bem demais!");
		}
		Console.WriteLine("R$ {0:0.00}", saldo);
	}
}