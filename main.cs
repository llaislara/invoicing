using System;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // Ler o arquivo JSON
        string jsonText = File.ReadAllText("faturamento.json");

        // Desserializar o JSON para um objeto C#
        FaturamentoMensal faturamentoMensal = JsonSerializer.Deserialize<FaturamentoMensal>(jsonText);

        // Calculando o menor e o maior faturamento diário
        decimal menorFaturamento = faturamentoMensal.Faturamentos.Min();
        decimal maiorFaturamento = faturamentoMensal.Faturamentos.Max();

        // Calculando a média mensal do faturamento, ignorando dias sem faturamento
        decimal somaFaturamento = faturamentoMensal.Faturamentos.Where(valor => valor > 0).Sum();
        decimal mediaFaturamento = somaFaturamento / faturamentoMensal.Faturamentos.Count(valor => valor > 0);

        // Número de dias no mês em que o valor de faturamento diário foi superior à média mensal
        int diasAcimaDaMedia = faturamentoMensal.Faturamentos.Count(valor => valor > mediaFaturamento);

        // Exibindo os resultados
        Console.WriteLine($"Menor faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}

class FaturamentoMensal
{
    public decimal[] Faturamentos { get; set; }
}
