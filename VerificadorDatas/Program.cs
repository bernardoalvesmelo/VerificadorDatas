namespace VerificadorDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Verificador de Datas de Geração de Testes***\n");

            Teste teste = new Teste();
            DateTime dataGeracao = ObterData();
            string tempoGeracao = teste.ObterData(dataGeracao);

            Console.WriteLine(tempoGeracao);
            Console.ReadLine();
        }

        static DateTime ObterData()
        {
            while (true)
            {
                Console.Write("Digite a data de geração: ");
                string data = Console.ReadLine();
                try
                {
                    DateTime dataGeracao = Convert.ToDateTime(data);
                    return dataGeracao;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFormato de data inválido!");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            }
        }
    }
}