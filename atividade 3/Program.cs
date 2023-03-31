//primeiro lado
Console.WriteLine($"Quantos cm tem o primeiro lado do triangulo?");
int lado1 = int.Parse(Console.ReadLine());

//segundo lado
Console.WriteLine($"Quantos cm tem o segundo lado do triangulo?");
int lado2 = int.Parse(Console.ReadLine());

//terceiro lado
Console.WriteLine($"Quantos cm tem o terceiro lado do triangulo?");
int lado3 = int.Parse(Console.ReadLine());

//processo
if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($"Temos um triangulo equilatero! Todos os lado sao iguas");
} 
else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
{
    Console.WriteLine($"Temos um triangulo escaleno! Todos os lados sao diferentes");
}
else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine($"Temos um triangulo isoscele! Dois dos lados sao iguais");
}
