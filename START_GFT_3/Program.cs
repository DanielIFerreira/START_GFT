using System;

namespace START_GFT_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            Console.WriteLine("Seu rendimento da conta corrente foi: R$ " + contaCorrente.Rendimento(100));
            Console.WriteLine("Imposto cobrado na conta corrente: R$ " + contaCorrente.Imposto(100));
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            Console.WriteLine("Seu rendimento da conta poupança foi: R$ " + contaPoupanca.Rendimento(100));
            Console.WriteLine("Imposto cobrado na conta poupança: R$ " + contaPoupanca.Imposto(100));

        }
    }
}
