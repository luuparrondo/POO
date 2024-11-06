using System;
class Coche : Vehiculo
{
    // Propiedad específica de los coches
    public double VelocidadMaxima { get; set; }

    // Constructor de la clase Coche que llama al constructor de la clase base
    
    public Coche(string marca, string modelo, int año, int velocidadMaxima) : base(marca, modelo, año)
    {
        //base(marca, modelo, año)  // Llama al constructor de Vehiculo
        VelocidadMaxima = velocidadMaxima;
    }

    // Sobreescribir el método MostrarInformacion para incluir la velocidad máxima
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();  // Llama a la implementación de la clase base
        Console.WriteLine($"Velocidad Máxima: {VelocidadMaxima} km/h");
    }

    // Método específico de los coches
    public void Acelerar(double velocidad)
    {
        if (velocidad <= VelocidadMaxima)
        {
            Console.WriteLine($"El coche está acelerando a {velocidad} km/h.");
        }
        else
        {
            Console.WriteLine("¡La velocidad solicitada excede la velocidad máxima!");
        }
    }
}