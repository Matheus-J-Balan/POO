using POO_Encapsulamento.Models;

ContaCorrente cc = new ContaCorrente(0);
cc.numero = 1234;
cc.ExibirSaldo();

cc.Sacar(100);
cc.ExibirSaldo();

cc.Depositar(200);
cc.ExibirSaldo();

cc.Sacar(100);
cc.ExibirSaldo();