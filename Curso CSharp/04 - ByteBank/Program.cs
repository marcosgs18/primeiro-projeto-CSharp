using System;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";
            Console.WriteLine(contaBruno.titular);
            Console.WriteLine(contaBruno.saldo);
            
            bool resultadoSaque = contaBruno.Sacar(50);

            Console.WriteLine(contaBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaBruno.Depositar(500);
            Console.WriteLine(contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno R$ " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela R$ " + contaGabriela.saldo);

            bool resultadoTransferencia = contaBruno.Transferir(200, contaGabriela);

            Console.WriteLine("Saldo do Bruno R$ " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela R$ " + contaGabriela.saldo);
            Console.WriteLine("Resultado transferência " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
