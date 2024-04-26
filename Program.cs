namespace Conta_bancaria;

class Program
{
    static void Main()
    {
        ContaPoupanca contaPoupanca = new ContaPoupanca(1881, 1500, 0.13);
        ContaCorrente contaCorrente = new ContaCorrente(2101, 2900, 17);

        contaPoupanca.Depositar(504);
        contaPoupanca.Sacar(200);
        contaPoupanca.AplicarJuros();

        contaCorrente.Depositar(4400);
        contaCorrente.Sacar(700);

        Console.WriteLine("O saldo total da sua conta poupanca eh de: " + contaPoupanca.Saldo);
        Console.WriteLine("O saldo total da sua conta Corrente eh de: " + contaCorrente.Saldo);
    }
}