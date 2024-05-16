using NewTalent;

namespace NewTalentTest;

public class UnitTest1
{

    public Calculadora ConstruirCalculadora()
    {
        Calculadora calculadora = new Calculadora("15/05/2024");
        return calculadora;
    }
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]

    public void SomarTest(int val1, int val2, int resposta)
    {
        Calculadora calculadora = ConstruirCalculadora();

        int resultado = calculadora.somar(val1, val2);
        
        Assert.Equal(resposta,resultado);
    }
    
    
    [Theory]
    [InlineData(1,2,2)]
    [InlineData(4,5,20)]
    
    public void MultiplicarTeste(int val1, int val2, int resposta)
    {
        Calculadora calculadora = ConstruirCalculadora();

        int resultado = calculadora.multiplicar(val1, val2);
        
        Assert.Equal(resposta,resultado);
    }
    
    
    [Theory]
    [InlineData(1,2,-1)]
    [InlineData(5,4,1)]
    
    public void SubtrairTeste(int val1, int val2, int resposta)
    {
        Calculadora calculadora = ConstruirCalculadora();

        int resultado = calculadora.subtrair(val1, val2);
        
        Assert.Equal(resposta,resultado);
    }
    
    
    [Theory]
    [InlineData(2,1,2)]
    [InlineData(5,10,0)]
    
    public void DividirTeste(int val1, int val2, int resposta)
    {
        Calculadora calculadora = ConstruirCalculadora();

        int resultado = calculadora.dividir(val1, val2);
        
        Assert.Equal(resposta,resultado);
    }
    
    [Fact]
    public void DividirPorZeroTeste()
    {
        Calculadora calculadora = ConstruirCalculadora();
        
        Assert.Throws<DivideByZeroException>(
            () => calculadora.dividir(3,0));
    }
    
    [Fact]
    public void TestarHitorico()
    {
        Calculadora calculadora = ConstruirCalculadora();

        calculadora.somar(3, 5);
        calculadora.somar(7, 23);
        calculadora.somar(132, 5);
        calculadora.somar(33, 35);

        var lista  = calculadora.historico();
        
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }
}