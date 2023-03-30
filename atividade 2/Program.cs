//primeiro time (Vasco)
Console.WriteLine($"Quantos gols o Vasco fez?");
int vasco = int.Parse(Console.ReadLine());

//segundo time (Cruzeiro)
Console.WriteLine($"E quantos o Cruzeiro ja fez?");
int cruzeiro = int.Parse(Console.ReadLine());

if (vasco == cruzeiro)
{
    Console.WriteLine($"Empate!");
} else if (vasco > cruzeiro)
{
    Console.WriteLine($"Vasco ganhou!");
} else {
    Console.WriteLine($"Cruzeiro ganhou!");
}