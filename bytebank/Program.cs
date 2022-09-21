using bytebank;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Dennis Bozzi";
conta1.conta = "10920-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 325.50;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta:" + conta1.conta);
Console.WriteLine("Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.ReadKey();