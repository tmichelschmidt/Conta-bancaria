using System;

public class ContaBancaria
{
	public int NumeroDaConta { get; set; }
	public double Saldo { get; set; }

	public ContaBancaria(int numeroDaConta, double saldo)
	{
		NumeroDaConta = numeroDaConta;
		Saldo = saldo;
	}

	public virtual void Depositar(double valor)
	{
		Saldo += valor;
	}

	public virtual void Sacar(double valor)
	{
		if (Saldo >= valor)
		{
			Saldo -= valor;
		}
		else
		{
			Console.WriteLine("O senhor nao tem dinherio o suficiente para realizar o seu saque ");
		}
	}
}

