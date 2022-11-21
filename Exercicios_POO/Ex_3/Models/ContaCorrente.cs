using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_3.Models
{
    public class ContaCorrente
    {
        public string? nomeCorrentista { get; set; }
        public int numeroConta { get; set; }
        public int numeroAgencia { get; set; }
        private decimal saldo { get; set; }

        public ContaCorrente(decimal saldoInicial){
            saldo = saldoInicial;
        }
        public void InserirSaldo(decimal valor){
            saldo = saldo + valor;
        }

        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo é: R$" + saldo);
        }
    }
}