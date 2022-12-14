using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Checkpoint.models
{
    public class ContaPoupanca : Conta, IConta
    {
        public double Juros { get; set; }

        public override void ExibirTipoDeConta()
        {
            Console.WriteLine("Conta Poupança");
        }

        public override void ExibirResumoConta()
        {
            base.ExibirResumoConta();
            Console.WriteLine($"Juros: {Juros}");
        }

        public void EncerrarConta()
        {
            Console.WriteLine("Encerrando a conta poupança");
        }
    }
}