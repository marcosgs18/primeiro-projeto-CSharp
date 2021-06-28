using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.Cpf = "'174.285.974.50";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente;
            conta.Saldo(-10);

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.Cpf);
            Console.WriteLine(conta.Titular.Profissao);
            Console.WriteLine(conta.Saldo);
        }
    }
}
