using System;

// Clase base Vehiculo
class Vehiculo
{
    // Propiedades comunes a todos los vehículos
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    
    // Constructor de la clase base Vehiculo
    public Vehiculo(string marca, string modelo, int año)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
    }

    // Método para mostrar información del vehículo
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Vehículo: {Marca} {Modelo} ({Año})");
    }
}
