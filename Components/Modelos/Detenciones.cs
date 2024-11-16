

using System.ComponentModel.DataAnnotations;

public class Detenciones {

    public int ID{set; get;}=0;
    public string Nombre{set; get;}= string.Empty;
    public string Apellido{set; get;}= string.Empty;
    public int Pasaporte {set; get;}=0;
    public DateTime? FechaN{get; set;}
    public DateTime? FechaD{get; set;}= DateTime.Now;
    public Double Latitud {set; get;}=0;
    public Double Longitud {set; get;}=0;
}