using System.Security;

Console.WriteLine("Digite um número:");

// Lê a entrada do usuário como uma string
string possivelFibo = Console.ReadLine();

if (int.TryParse(possivelFibo, out int numero))
{


    if (Fibonacci(numero))
    {
        Console.WriteLine("O número digitado pertence à sequência de Fibonacci.");
    }
    else
    {
        Console.WriteLine("O número digitado não pertence à sequência de Fibonacci.");
    }
}
else
{
    Console.WriteLine("O valor digitado não é um número válido.");
}


bool Fibonacci(int numero)
{
    int a = 0;
    int b = 1;


    if (numero == 0 || numero == 1)
        return true;

    while (b <= numero)
    {
        int soma = a + b;

        if (soma == numero)
            return true;

        a = b;
        b = soma;
    }

    return false;
}