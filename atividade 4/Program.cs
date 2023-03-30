//senha digitada
Console.WriteLine($"Digite sua senha:");
int senhaDigitada = int.Parse(Console.ReadLine());

//senha correta
int senhaCorreta = 1234;

if (senhaDigitada == senhaCorreta)
{
    Console.WriteLine($"Acesso liberado.");
}
else
{
    Console.WriteLine($"Acesso negado");
}