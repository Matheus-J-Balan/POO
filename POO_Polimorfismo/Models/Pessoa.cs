using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Polimorfismo.Models
{
    public class Pessoa
    {
        public string? nome { get; set; }
        public int idade { get; set; }
        public virtual void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {nome}, e tenho {idade} anos");
        }
    }
}