namespace MeuPrimeiroTeste.Tests;

public class UnitTest1
{
    [Fact]
    public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio()
    {
        // Arrange (Preparação)
        var service = new HelloWorldService();

        // Act (Ação)
        var resultadoNulo = service.GerarSaudacao(null);
        var resultadoVazio = service.GerarSaudacao(string.Empty);

        // Assert (Verificação)
        Assert.Equal("Olá, Mundo!", resultadoNulo);
        Assert.Equal("Olá, Mundo!", resultadoVazio);
    }

    [Fact]
    public void GerarSaudacao_IncluiNome_QuandoNomeEhInformado()
    {
        var service = new HelloWorldService();

        Assert.Equal("Olá, Bernardo!", service.GerarSaudacao("Bernardo"));
    }
}
