using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Encapsulamento.Models
{
    public class ContaCorrente
    {
        public int numero { get; set; }
        private decimal saldo { get; set; }

        public ContaCorrente(decimal saldoInicial)
        {
         saldo = saldoInicial;   
        }

        public void Depositar(decimal valor){
            if(valor > 0){
             saldo += valor;
             Console.WriteLine("Deposito de " + valor + " realizado com sucesso");
            }else
              Console.WriteLine("Valor invalido!");

        }
        public void Sacar (decimal valor){
           if(valor <= saldo){
            saldo -= valor;
            Console.WriteLine("Saldo de " + valor + " realizado com sucesso"); 
           }else
            Console.WriteLine("Saldo insuficiente!");
        }

        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo é: R$" + saldo);
        }
    }
}