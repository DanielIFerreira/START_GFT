using System;
using System.Collections.Generic;
using System.Text;

namespace START_GFT_3
{
    abstract class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Imposto { get; set; }


        public void Rendimento(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public double calcularImposoto(double imposto)
        {
          return   this.Imposto = imposto;
        }
    }
}
