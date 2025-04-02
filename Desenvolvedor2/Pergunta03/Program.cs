using Newtonsoft.Json;

class Program
{
    // Classe para representar cada item do JSON
    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }

    static void Main(string[] args)
    {
      
        try
        {

            string caminhoArquivo = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "dados.json");

            string json = File.ReadAllText(caminhoArquivo);

            var listFaturamento = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            var menorFaturamento = listFaturamento?.Min(d => d.Valor);

            Console.WriteLine($"O menor valor de faturamento foi: {menorFaturamento}");



        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler o arquivo JSON: {ex.Message}");
        }
    }
}