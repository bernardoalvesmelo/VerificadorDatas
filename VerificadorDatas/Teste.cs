namespace VerificadorDatas
{
    public class Teste
    {
        public string ObterData(DateTime dataGeracao)
        {
            return ObterData(dataGeracao, DateTime.Now);
        }

        public string ObterData(DateTime dataGeracao, DateTime dataAgora)
        {
            if(dataGeracao > dataAgora)
            {
                return "Data de geração de teste maior que data atual";
            }

            TimeSpan diferenca = dataAgora - dataGeracao;
            
            int periodo = 0;
            string medida = "";

            if(diferenca.TotalDays >= 365)
            {
                periodo = (int)Math.Floor(diferenca.TotalDays / 365);
                medida = periodo == 1 ? "ano" : "anos";
            }

            else if(diferenca.TotalDays >= 30)
            {
                periodo = (int)Math.Floor(diferenca.TotalDays / 30);
                medida = periodo == 1 ? "mês" : "meses";
            }

            else if(diferenca.TotalDays >= 7)
            {
                periodo = (int)Math.Floor(diferenca.TotalDays / 7);
                medida = periodo == 1 ? "semana" : "semanas";
            }

            else if(diferenca.TotalDays >= 1)
            {
                periodo = (int)Math.Floor(diferenca.TotalDays);
                medida = periodo == 1 ? "dia" : "dias";
            }

            else if(diferenca.TotalHours >= 1)
            {
                periodo = (int)Math.Floor(diferenca.TotalHours);
                medida = periodo == 1 ? "hora" : "horas";
            }

            else if(diferenca.TotalMinutes >= 1)
            {
                periodo = (int)Math.Floor(diferenca.TotalMinutes);
                medida = periodo == 1 ? "minuto" : "minutos";
            }

            else if (diferenca.TotalSeconds >= 1)
            {
                periodo = (int)Math.Floor(diferenca.TotalSeconds);
                medida = periodo == 1 ? "segundo" : "segundos";
            }

            else
            {
                periodo = (int)Math.Floor(diferenca.TotalMilliseconds);
                medida = periodo == 1 ? "milisegundo" : "milisegundos";
            }

            return $"Teste realizado {periodo} {medida} atrás";
        }
    }
}
