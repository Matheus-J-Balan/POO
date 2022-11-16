using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Polimorfismo.Models
{
    public class Aluno : Pessoa
    {
         public double nota { get; set; }

        public override void Apresentar()
        {
             Console.WriteLine($"Olá, meu nome é {nome}, tenho {idade} anos e minha nota é {nota}");
        }
    }
}