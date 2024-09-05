// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Tipos Primitivos
int numeroInteiro = 42;
long numeroLongo = 1234567890L;
float numeroFlutuante = 3.14f;
double numeroDouble = 3.14159265358979;
decimal numeroDecimal = 12345.6789m;
char caractere = 'A';
bool verdadeiroOuFalso = true;

//Strings
string texto = "Olá,Mundo!";
string textoMultilinha = @"Esta é uma string multilinha com @";

Console.WriteLine($"Numero Inteiro: {numeroInteiro}");
Console.WriteLine($"Numero Longo: {numeroLongo}");
Console.WriteLine($"Numero Flutuante: {numeroFlutuante}");
Console.WriteLine($"Numero Double: {numeroDouble}");
Console.WriteLine($"Numero Decimal: {numeroDecimal}");
Console.WriteLine($"Caractere: {caractere}");
Console.WriteLine($"Booleano: {verdadeiroOuFalso}");
Console.WriteLine($"Texto: {texto}");
Console.WriteLine($"Texto Multilinha: {textoMultilinha}");

Console.ReadKey();
