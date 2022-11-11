using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Checkpoint.models
{
    public class ContaPoupanca
    {
        public string? nome { get; set; }
        public int numero { get; set; }
        public int agencia { get; set; }
        public double saldo { get; set; }
        public double juros { get; set; }
        public void Depositar(){
            saldo = saldo + juros;
        }
    }
}