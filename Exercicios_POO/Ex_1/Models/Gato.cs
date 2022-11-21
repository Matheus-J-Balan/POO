using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_1.Models
{
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"Miou");        
        }
    }
}