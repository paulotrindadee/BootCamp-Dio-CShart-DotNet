using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Models
{
    public class Pessoa // class
    {//Atributos 
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {//Métodos


            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. ");

            // "\n" para quebra de linha
         }
    }
}