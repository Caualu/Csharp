Console.WriteLine("Exemplo com 'if':");

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite um número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

int soma = numero + numero2;
     
if (soma > 70)
{
    Console.WriteLine("finaciamento aprovado.");
}
else
{
    Console.WriteLine("finaciamento reprovado");
}

Console.ReadKey();


