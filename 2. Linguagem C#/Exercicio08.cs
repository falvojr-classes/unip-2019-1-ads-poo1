using System;
					
public class Exercicio08
{
	public static void Main()
	{
		// Criamos a Agencia
		Agencia agenciaAra = new Agencia();
		agenciaAra.Nome = "Araraquara";
		
		// Criamos um Cliente
		Cliente venilton = new Cliente();
		venilton.Nome = "Venilton";
		
		// Criamos uma Conta
		Conta contaCorrente = new Conta();
		contaCorrente.Numero = 1;
		// Relaciona a Conta com nossa Agencia
		contaCorrente.Agencia = agenciaAra;
		// Relaciona a Conta com o Cliente
		contaCorrente.Cliente = venilton;
		
		// Criamos um Cartao
		Cartao cartaoCredito = new Cartao();
		cartaoCredito.Numero = 1234;
		// Relaciona a Cartao com o Cliente
		cartaoCredito.Cliente = venilton;
		
		// Imprime o nome da Agencia (2 formas)
		Console.WriteLine(contaCorrente.Agencia.Nome);
		Console.WriteLine(agenciaAra.Nome);
		// Imprime o nome do Cliente (2 formas)
		Console.WriteLine(cartaoCredito.Cliente.Nome);
		Console.WriteLine(venilton.Nome);
	}
}

public class Cliente {
    public string Nome;
    public string Documento;
}

public class Cartao {
    public long Numero;
    public double Saldo;
    public double Limite;
	// Atributo que relaciona o Cliente com o Cartao (1 para N)
	public Cliente Cliente;
}

public class Conta {
    public long Numero;
    public double Saldo;
    public double Limite;
	// Atributo que relaciona o Cliente com o Conta (1 para 1)
	public Cliente Cliente;
	// Atributo que relaciona o Agencia com o Conta (1 para N)
	public Agencia Agencia;
}

public class Agencia {
	public long Numero;
	public string Nome;
}
