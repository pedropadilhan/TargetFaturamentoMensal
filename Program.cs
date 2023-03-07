namespace TargetFaturamentoMensal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double faturamentoSP = 67836.43, faturamentoRJ = 36678.66, faturamentoMG = 29229.88, faturamentoES = 27165.48, faturamentoOutros = 19849.53;

            double total = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

            double percSP = (faturamentoSP / total) * 100;
            double percRJ = (faturamentoRJ / total) * 100;
            double percMG = (faturamentoMG / total) * 100;
            double percES = (faturamentoES / total) * 100;
            double percOutros = (faturamentoOutros / total) * 100;

            Console.WriteLine("Percentual de cada estado no lucro mensal:");
            Console.WriteLine("SP: " + Math.Round(percSP, 2));
            Console.WriteLine("RJ: " + Math.Round(percRJ, 2));
            Console.WriteLine("MG: " + Math.Round(percMG, 2));
            Console.WriteLine("ES: " + Math.Round(percES, 2));
            Console.WriteLine("Outros: " + Math.Round(percOutros, 2));
        }
    }
}