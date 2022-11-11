using POO_Checkpoint.models;

ContaCorrente contaC = new ContaCorrente();

contaC.nome = "Matheus";
contaC.agencia = 123;
contaC.numero = 3586;
contaC.saldo = 200;
contaC.tarifa = 15;
contaC.Depositar(400);  
contaC.ExibirResumoConta();