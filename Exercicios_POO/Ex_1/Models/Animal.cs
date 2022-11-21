using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_1.Models
{
    public class Animal
    {
        public string? raca { get; set; }
        public double tam { get; set; }

        public virtual void EmitirSom(){
            Console.WriteLine($"{raca} emitiu um som");
        }
    }
}