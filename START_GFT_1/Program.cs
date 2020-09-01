using System;

namespace START_GFT_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorInicial=0;
            int valorFinal=0;

            Console.WriteLine("Digite um valor inicial");
            valorInicial = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Digite um valor final");
            valorFinal = Convert.ToInt32(Console.ReadLine());

            for (int i = valorInicial; i <= valorFinal; i++ )
            {
                if (i % 2 != 0)
                {
                        Console.WriteLine(i + " ");
                }
            }
            

        }
    }
}
