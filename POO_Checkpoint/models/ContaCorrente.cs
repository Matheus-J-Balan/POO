using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Checkpoint.models
{
    public class ContaCorrente
    {
        public string? nome { get; set; }
        public int numero { get; set; }
        public int agencia { get; set; }
        public double saldo { get; set; }
        public double tarifa { get; set; }

        public void Depositar(double valor){
            saldo = saldo + valor;
        }

        public void ExibirResumoConta(){
            Console.WriteLine($"Correntista: {nome}");
            Console.WriteLine($"Numero: {numero}");
            Console.WriteLine($"Agência: {agencia}");  
            Console.WriteLine($"Saldo: {saldo}");
        }
    }
}