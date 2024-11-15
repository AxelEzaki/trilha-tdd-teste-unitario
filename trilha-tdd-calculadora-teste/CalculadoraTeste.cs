using trilha_tdd_calculadora_api.Entidade;

namespace trilha_tdd_calculadora_teste;

public class CalculadoraTeste
{
    public Calculadora construirClasse()
    {
        string data = "15/11/2024";

        Calculadora _calc = new Calculadora(data);

        return _calc;
    }

    [Theory]
    [InlineData(1, 4, 5)]
    [InlineData(5, 5, 10)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora _calc = construirClasse();

        var resultadoCalc = _calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalc);
    }
    
    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(10, 3, 7)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora _calc = construirClasse();

        var resultadoCalc = _calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalc);
    }
    
    [Theory]
    [InlineData(7, 4, 28)]
    [InlineData(5, 9, 45)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora _calc = construirClasse();

        var resultadoCalc = _calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalc);
    }
    
    [Theory]
    [InlineData(20, 4, 5)]
    [InlineData(5, 5, 1)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora _calc = construirClasse();

        var resultadoCalc = _calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Fact]
    public void TesteDividirPorZero()
    {
        Calculadora _calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => {
            _calc.Dividir(5, 0);
        });
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora _calc = construirClasse();

        _calc.Somar(4, 5);
        _calc.Subtrair(3, 1);
        _calc.Multiplicar(10, 2);
        _calc.Somar(7, 6);
        _calc.Dividir(80, 10);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count());
    }
}