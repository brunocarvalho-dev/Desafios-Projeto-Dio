namespace PrimeiroDesafioComPOOTeste;

public class UnitTest1
{
    [Fact]
    public void DeveTestarEntradaNomeEIdadeSaidaNomeEIdadeInformados()
    {
        //Abstract
        string nome = "João";
        int idade = 26;

        //Act
        string texto = $"Nome: {nome}, Idade: {idade}";

        //Assert
        Assert.Equal("Nome: João, Idade: 26", texto);
    }
}