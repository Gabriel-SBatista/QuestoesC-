using System;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
}

public class ContaBancaria
{
    private double saldo;

    public void Sacar(double valor)
    {
        try
        {
            if (valor > saldo)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para realizar o saque.");
            }
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso.");
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}