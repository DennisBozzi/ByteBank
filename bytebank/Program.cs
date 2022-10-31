using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!\n");

//conta1
/*ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Dennis Bozzi";
conta1.conta = "10920-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;

//conta2
ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Tevis";
conta2.conta = "10920-x";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Agencia Central";
conta2.saldo = 100;

Console.WriteLine("O saldo de Dennis antes de tudo e: " + conta1.saldo);
Console.WriteLine("O Saldo de Amanda antes de tudo e: " + conta2.saldo);

Console.WriteLine();

transferencia = conta1.Transferir(50, conta2);

Console.WriteLine("Tranferencia realizada com sucesso? " + transferencia);
Console.WriteLine("O Saldo de Amanda depois de tudo e: " + conta2.saldo);
Console.WriteLine("O saldo de Dennis depois de tudo e: " + conta1.saldo);

Cliente cliente = new Cliente();
cliente.nome = "Dennis Bozzi";
cliente.cpf = "10988042797";
cliente.profissao = "Programador C#";

ContaCorrente conta3 = new ContaCorrente();
cliente.nome = "Dennis Bozzi";
cliente.cpf = "10988042797";
cliente.profissao = "Programador C#";
conta3.conta = "2513252-x";
conta3.numero_agencia = 35;
conta3.nome_agencia = "Agencia Central";

Console.WriteLine(cliente.nome);
Console.WriteLine(conta3.titular.nome);

if (conta3.titular == null)
{
    Console.WriteLine("Dennis e lindo");
}
*/

ContaCorrente conta4 = new ContaCorrente();

conta4.saldo = -10;
Console.WriteLine(conta4.saldo);

Console.ReadKey();