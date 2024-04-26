public class ContaPoupanca : ContaBancaria
{
    public double TaxaDeJuros { get; set; }

    public ContaPoupanca(int numeroDaConta, double saldo, double taxaDeJuros)
        : base(numeroDaConta, saldo)
    {
        TaxaDeJuros = taxaDeJuros;
    }

    public void AplicarJuros()
    {
        Saldo += Saldo * TaxaDeJuros;
    }
}