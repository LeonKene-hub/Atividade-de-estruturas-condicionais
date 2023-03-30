//total recebido
Console.Write($"Digite o valor total do salario recebido:");
int salario = int.Parse(Console.ReadLine());

//total gasto
Console.Write($"Digite o valor total gasto este mes:");
int gasto = int.Parse(Console.ReadLine());

if (salario >= gasto)
{
    Console.WriteLine($"Gastos dentro do orcamento");
} 
else
{
    Console.WriteLine($"Orcamento estourado");
}