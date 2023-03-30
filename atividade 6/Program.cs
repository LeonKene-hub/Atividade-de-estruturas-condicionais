//frequencia
Console.WriteLine($"Em porcentagem, qual a frequencia do aluno?");
int frequencia = int.Parse(Console.ReadLine());

//meida do aluno
Console.WriteLine($"Qual foi a media do aluno?");
int media = int.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine($"Aluno reprovado!");
}
else if (media  >= 3 && media < 7)
{
    Console.WriteLine($"Aluno em recuperacao");
}
else
{
    Console.WriteLine($"Aluno aprovado");
}