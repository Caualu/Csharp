// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Exemplo com 'if' e 'else':");

Console.Write("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());
double numeroNovo;
if (numero > 0)
{
    numeroNovo = numero * 5;
    Console.WriteLine("o numero e positivo");
}
else if (numero == 0)
{
    Console.WriteLine("o numero e zero");
}
else
{

    Console.WriteLine("o numero nao e positivo");

}

// Mantém a janela do console aberta
Console.ReadKey();

