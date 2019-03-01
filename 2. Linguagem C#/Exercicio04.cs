using System;
					
public class Exercicio04
{
	public static void Main()
	{
		int a = 2, b = 6, c = 3;
		double delta, a1, a2;
			
		delta = Math.Pow(b, 2) - 4*a*c;
		if (delta < 0) {
			Console.WriteLine("O valor de delta é negativo.");
		} else {	
			a1 = (-b + Math.Sqrt(delta)) / (2 * a);
			a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            // Exemplo de impressão usando um padrão de formatacão:
			Console.WriteLine("A1={0}, A2={1}, Delta={2}", a1, a2, delta);
            // Exemplo de impressão usando concatenacão de strings:
			Console.WriteLine("A1=" + a1 + ", A2=" + a2 + ", Delta=" + delta);
		}
	}
}