using System;

class Moto : Vehiculo
{
    public bool TieneSidecar { get; set; }

    public Moto(string marca, string modelo, int año, bool tieneSidecar)
        : base(marca, modelo, año)
    {
        TieneSidecar = tieneSidecar;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"¿Tiene Sidecar? {(TieneSidecar ? "Sí" : "No")}");
    }
}
