using System;
using System.Collections.Generic;
using System.Text;

namespace START_GFT_3
{
    class ContaPoupanca : Conta
    {
        public double Rendimento(double saldo)
        {
            return saldo * 0.05;
        }

        public double Imposto(double imposto)
        {
            return imposto * 0.1;
        }

    }
}
