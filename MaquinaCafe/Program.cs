using System;


class Program
{
    static void Main(string[] args)
    {
        var maquina = new MaquinaCafe();  // Instanciar la clase MaquinaCafe

        // Preguntar el tamaño de vaso
        Console.WriteLine("Selecciona el tamaño del vaso (Pequeño, Mediano, Grande):");
        string tamañoVaso = Console.ReadLine();

        // Obtener el resultado de la selección de vaso
        int cantidadCafe = maquina.SeleccionarVaso(tamañoVaso);  // Selecciona el vaso y obtiene la cantidad en onzas

        // Convertir el resultado a string para mostrarlo
        Console.WriteLine($"Has seleccionado un vaso con: {cantidadCafe.ToString()} Oz de café.");
    }
}