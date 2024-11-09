using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test
{
    public class OfertaViagemTest
    {
        [Fact]
        public void TestandoOfertaValida()
        {
            //cenário - arrange
            Rota rota = new Rota("OrigemTeste", "DestinoTeste");
            Periodo periodo = new Periodo(new DateTime(2024, 10, 31), new DateTime(2024, 11, 10));
            double preco = 100.0;
            var validacao = true;

            //ação - act
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //validação - assert
            Assert.Equal(validacao, oferta.EhValido);
        }

        [Fact]
        public void TestandoOfertaComRotaNula()
        {
            //cenário - arrange
            Rota rota = null!;
            Periodo periodo = new Periodo(new DateTime(2024, 10, 31), new DateTime(2024, 11, 10));
            double preco = 100.0;

            //ação - act
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //validação - assert
            Assert.Contains("A oferta de viagem não possui rota ou período válidos.", oferta.Erros.Sumario);
            Assert.False(oferta.EhValido);
        }

    }
}