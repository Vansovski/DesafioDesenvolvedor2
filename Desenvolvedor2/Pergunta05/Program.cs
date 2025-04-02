class Program
{
    static void Main(string[] args)
    {
        string texto = "DesafioDesenvolvedor02";

        List<char> listaCaracteres = new List<char>(texto.ToCharArray());

        var tamanho = texto.Length;

       
        Console.WriteLine("String Invertida:");
        for (int i = tamanho - 1; i >= 0; i--)
        {
            Console.Write(listaCaracteres[i]);
        }
    }
}