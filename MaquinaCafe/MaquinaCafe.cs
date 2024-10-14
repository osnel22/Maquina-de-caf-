public class MaquinaCafe
{
    private int vasosDisponibles = 10;

    public int SeleccionarVaso(string tamaño)
    {
        if (vasosDisponibles <= 0)
        {
            throw new InvalidOperationException("No hay vasos disponibles");
        }

        switch (tamaño)
        {
            case "Pequeño":
                return 3;
            case "Mediano":
                return 5;
            case "Grande":
                return 7;
            default:
                throw new ArgumentException("Tamaño de vaso inválido");
        }
    }


    public int SeleccionarAzucar(int cucharadas)
    {
        return cucharadas;
    }

    public void SetVasosDisponibles(int cantidad)
    {
        vasosDisponibles = cantidad;
    }
}
