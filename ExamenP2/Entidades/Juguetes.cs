using System.ComponentModel.DataAnnotations;

namespace ExamenP2;

public class Juguetes
{
    public Juguetes()
    {
    }

    [Key]
    public Guid idJuguetes { get; set; }
    public Marca Codigo { get; set; }
    public required string Nombre { get; set; }
    public required int Precio { get; set; }
    public DateTime Vigencia { get; set; }
    public bool Activo { get; set; }
    
}