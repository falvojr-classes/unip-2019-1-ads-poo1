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
		
		contaCorrente.ImprimirExtrato();
		contaCorrente.Depositar(50);
        contaCorrente.Sacar(10);
        contaCorrente.Sacar(5, 0);
		contaCorrente.ImprimirExtrato();
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

    // Por padrão, todas as Contas têm um limite de R$500,00.
    public Conta() {
        this.Limite = 500;
    }

    /* Alternativamente, um limite diferenciado pode ser especificado
       na criacão de uma conta */
    public Conta(double limite) {
        this.Limite = limite;
    }

    // Clientes podem imprimir seu extrato a partir de sua Conta.
    public void ImprimirExtrato() {
        Console.WriteLine(this.Cliente.Nome);
        Console.WriteLine("Saldo: {0:0.00}", this.Saldo);
        Console.WriteLine("Limite: {0:0.00}", this.Limite);
    }

    // Clientes podem depositar em sua Conta sem nenhuma taxa. 
    public void Depositar(double valor) {
        this.Saldo += valor;
    }

    // Clientes podem sacar da sua Conta com uma taxa padrão de R$0.50.
    public void Sacar(double valor) {
        this.Sacar(valor, 0.5);
    }

    // Podem existir casos de taxa diferenciada de taxa.
    public void Sacar(double valor, double taxa) {
        this.Saldo -= (valor + taxa);
    }
}

public class Agencia {
	public long Numero;
	public string Nome;
}
