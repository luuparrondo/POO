using System;
class Program
{
    private static void Main(string[] args)
    {
        // Crear objetos de tipo Coche
        Coche coche1 = new Coche("Toyota", "Corolla", 2020, 180);
        Coche coche2 = new Coche("BMW", "X5", 2022, 240);

        // Mostrar información de los coches
        coche1.MostrarInformacion();
        coche2.MostrarInformacion();

        // Simular aceleración
        coche1.Acelerar(150);
        coche2.Acelerar(260);
        
        Moto moto1 = new Moto("Vespa", "Ejemplo", 2020, true);

        moto1.MostrarInformacion();
    }
}