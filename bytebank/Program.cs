using bytebank;
using bytebank.Titular;

//Console.WriteLine("Boas vindas ao seu Banco, ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "Gabriel Henrique";
//conta1.conta = "666-x";
//conta1.numero_agencia = 60;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 1000.00;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Rafael Maciel";
//conta2.conta = "242-x";
//conta2.numero_agencia = 60;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 600.00;

//Console.WriteLine("Saldo da Amanda pré-tranferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pré-tranferência: " + conta1.saldo);
//conta1.Transferir(50, conta2);
//Console.WriteLine("Saldo da Amanda pós-tranferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pós-tranferência: " + conta1.saldo);
//conta1.ExibirDadosDaConta();

//Cliente cliente = new Cliente();
//cliente.nome = "Gabriel Henqique";
//cliente.cpf = "038.757.031-06";
//cliente.profissao = "Programador C#";
//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular.nome = "Gabriel Henrique";
//conta3.titular.profissao = "programador C#";
//conta3.titular.cpf = "03875734166";
//conta3.conta = "8547865-x";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agencia Central";

Cliente Sarah = new Cliente();
Sarah.Nome = "Sarah Silva";

ContaCorrente conta4 = new ContaCorrente(235, "546132-x");
conta4.Saldo = 150;
conta4.Titular = Sarah;
Console.WriteLine(conta4.Titular.Nome);
Console.WriteLine(conta4.Saldo);
Console.WriteLine(conta4.Numero_agencia);
Console.WriteLine(conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(635, "897546-x");

ContaCorrente conta6 = new ContaCorrente(157, "693985-x");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


Console.ReadKey();
