// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Exemplo com 'if' e 'else':");

Console.Write("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());
double numeroNovo;
if (numero % 3 == 0)
{
    numeroNovo = numero * 5;
    Console.WriteLine("Como e divisivel por 3, multiplicamos por 5 e ele virou:" + numeroNovo);
}
else
{
    numeroNovo = numero * 3;
    Console.WriteLine("como nao e divisivel por 3, multiplicamos 3 e ele virou:" + numeroNovo);

}

// Mantém a janela do console aberta
Console.ReadKey();
        
