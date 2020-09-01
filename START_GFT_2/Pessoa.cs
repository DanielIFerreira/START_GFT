using System;
using System.Collections.Generic;
using System.Text;

namespace START_GFT_2
{
    class Pessoa
    {
        private string  Nome { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }

         public Pessoa(string nome, string endereco, string telefone)
         {

            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            
         }

        public void ExibirDados()
        {
            
            Console.WriteLine(Nome);
            Console.WriteLine(Endereco);
            Console.WriteLine(Telefone);

        }


    }
}
