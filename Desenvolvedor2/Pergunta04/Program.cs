using System;
using System.Collections.Generic;

public class FaturamentoUF
{
    public string? Uf { get; set; }
    public double Valor { get; set; }
}

class Program
{
    static void Main()
    {
        List<FaturamentoUF> listFaturamentoUF = new List<FaturamentoUF>();

        listFaturamentoUF.Add(new FaturamentoUF { Uf = "SP", Valor = 67836.43 });
        listFaturamentoUF.Add(new FaturamentoUF { Uf = "RJ", Valor = 36678.66 });
        listFaturamentoUF.Add(new FaturamentoUF { Uf = "MG", Valor = 29229.88 });
        listFaturamentoUF.Add(new FaturamentoUF { Uf = "ES", Valor = 27165.48 });
        listFaturamentoUF.Add(new FaturamentoUF { Uf = "Outros", Valor = 19849.53 });


        double totalFaturamento = listFaturamentoUF.Sum(faturamento => faturamento.Valor);

        foreach (var item in listFaturamentoUF)
        {
            Console.WriteLine($"O faturamento do estado {item.Uf} em percentual foi de {Math.Round((item.Valor/totalFaturamento)*100,2)}");
        }

    }
}