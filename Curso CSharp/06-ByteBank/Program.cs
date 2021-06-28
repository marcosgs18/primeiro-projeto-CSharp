using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 867938);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaGabriela = new ContaCorrente(867, 857694);

            Console.WriteLine(contaGabriela.Agencia);
            Console.WriteLine(contaGabriela.Numero);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}
