namespace VerificadorDatas.TestesUnitarios
{
    [TestClass]
    public class TesteTest
    {
        Teste teste;
        DateTime dataAgora;
        DateTime data;
        public TesteTest()
        {
            teste = new Teste();
            dataAgora = DateTime.Now;
            data = dataAgora.AddSeconds(0);
        }

        [TestMethod]
        public void Nao_deve_permitir_data_de_geracao_maior_que_data_atual()
        {
            data = data.AddMilliseconds(1);

            Assert.AreEqual("Data de geração de teste maior que data atual",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_milisegundos()
        {
            data = data.AddMilliseconds(-1);

            Assert.AreEqual("Teste realizado 1 milisegundo atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_milisegundos_no_plural()
        {
            data = data.AddMilliseconds(-2);

            Assert.AreEqual("Teste realizado 2 milisegundos atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_segundos()
        {
            data = data.AddSeconds(-1);
            
            Assert.AreEqual("Teste realizado 1 segundo atrás", 
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_segundos_no_plural()
        {
            data = data.AddSeconds(-2);

            Assert.AreEqual("Teste realizado 2 segundos atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_minutos()
        {
            data = data.AddMinutes(-1);

            Assert.AreEqual("Teste realizado 1 minuto atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_minutos_no_plural()
        {
            data = data.AddMinutes(-2);

            Assert.AreEqual("Teste realizado 2 minutos atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_horas()
        {
            data = data.AddHours(-1);

            Assert.AreEqual("Teste realizado 1 hora atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_horas_no_plural()
        {
            data = data.AddHours(-2);

            Assert.AreEqual("Teste realizado 2 horas atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_dias()
        {
            data = data.AddDays(-1);

            Assert.AreEqual("Teste realizado 1 dia atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_dias_no_plural()
        {
            data = data.AddDays(-2);

            Assert.AreEqual("Teste realizado 2 dias atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_semanas()
        {
            data = data.AddDays(-7);

            Assert.AreEqual("Teste realizado 1 semana atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_semanas_no_plural()
        {
            data = data.AddDays(-14);

            Assert.AreEqual("Teste realizado 2 semanas atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_meses()
        {
            data = data.AddDays(-30);

            Assert.AreEqual("Teste realizado 1 mês atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_meses_no_plural()
        {
            data = data.AddDays(-60);

            Assert.AreEqual("Teste realizado 2 meses atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_anos()
        {
            data = data.AddDays(-365);

            Assert.AreEqual("Teste realizado 1 ano atrás",
                teste.ObterData(data, dataAgora));
        }

        [TestMethod]
        public void Deve_mostrar_tempo_gerado_em_anos_no_plural()
        {
            data = data.AddDays(-730);

            Assert.AreEqual("Teste realizado 2 anos atrás",
                teste.ObterData(data, dataAgora));
        }
    }
}