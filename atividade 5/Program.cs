//macas valor
float macaValor = 0.30f;

//macas compradas
Console.WriteLine($"Quantas macas voce gostaria de comprar?");
int compradas = int.Parse(Console.ReadLine());

float resultado = 0;

if (compradas >= 12)
{
    macaValor = 0.25f;
    resultado = macaValor * compradas;
    Console.WriteLine(resultado);   
} 
else
{
    resultado = macaValor * compradas;
    Console.WriteLine(resultado);
}