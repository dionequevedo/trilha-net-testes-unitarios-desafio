using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Correções implementadas

        // Arrange
        string texto = "Matrix";
        int resultadoEsperado = 6;

        // Act
        int resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        string texto = "Esse é um texto qualquer";
        string textoProcurado = "qualquer";
        bool resultado;

        // Correção implementada!
        // Act
        resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        // Correção Implementada!
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        string texto = "Esse é um texto qualquer";
        string textoProcurado = "Teste";

        // Act
        bool resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //Correção implementada
        Assert.False(resultado);
    }

    // Anotação implementada
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //Correção implementada

        // Arrange
        string texto = "Começo, meio e fim do texto procurado";
        string textoProcurado = "procurado";

        // Act
        bool resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
