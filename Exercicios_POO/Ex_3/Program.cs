using Ex_3.Models;

ContaCorrente cc = new ContaCorrente(0);

cc.nomeCorrentista = "Roberto";
cc.numeroAgencia = 086;
cc.numeroConta = 5555;
cc.InserirSaldo(50);
cc.ExibirSaldo();