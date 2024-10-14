using Xunit;

public class MaquinaCafeTests
{
    [Fact]
    public void SeleccionarVaso_Pequeño_Devuelve3Oz()
    {
        var maquina = new MaquinaCafe();
        var resultado = maquina.SeleccionarVaso("Pequeño");
        Assert.Equal(3, resultado);
    }

    [Fact]
    public void SeleccionarVaso_Mediano_Devuelve5Oz()
    {
        var maquina = new MaquinaCafe();
        var resultado = maquina.SeleccionarVaso("Mediano");
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void SeleccionarVaso_Grande_Devuelve7Oz()
    {
        var maquina = new MaquinaCafe();
        var resultado = maquina.SeleccionarVaso("Grande");
        Assert.Equal(7, resultado);
    }

    [Fact]
    public void SeleccionarAzucar_2Cucharadas_DevuelveCorrecto()
    {
        var maquina = new MaquinaCafe();
        var resultado = maquina.SeleccionarAzucar(2);
        Assert.Equal(2, resultado);
    }
    [Fact]
    public void NoHayVasos_LanzaExcepcion()
    {
        var maquina = new MaquinaCafe();
        maquina.SetVasosDisponibles(0);

        Assert.Throws<InvalidOperationException>(() => maquina.SeleccionarVaso("Pequeño"));
    }

}
