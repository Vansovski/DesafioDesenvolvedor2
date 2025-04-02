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

            var menorFaturamento = listFaturamento?.OrderBy(x => x.Valor).First(); 
            var maiorFaturamento = listFaturamento?.OrderByDescending(x => x.Valor).First();

            var mediaFaturamento = listFaturamento?.Average(x => x.Valor);  

            int numDiasFaturamentoMaior = 0;    

            listFaturamento.ForEach(faturamento =>
            {
                if (faturamento.Valor > mediaFaturamento)
                {
                    numDiasFaturamentoMaior++;
                }
            });


            Console.WriteLine($"O menor valor de faturamento foi: {menorFaturamento?.Valor} no dia {menorFaturamento?.Dia}");
            Console.WriteLine($"O maior valor de faturamento foi: {maiorFaturamento?.Valor} no dia {maiorFaturamento?.Dia}");
        

            Console.WriteLine($"Número de dias com faturamento maior que a média: {numDiasFaturamentoMaior}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler o arquivo JSON: {ex.Message}");
        }
    }
}