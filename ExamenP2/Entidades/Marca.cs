using System.ComponentModel.DataAnnotations;

namespace ExamenP2;

public class Marca
{
    public Marca()
    {
    }

    [Key]
    public Guid idMarca { get; set; }
    public required int codigoMarca { get; set; }
    public required string nombreMarca { get; set; }
    public bool Activo { get; set; }
    
}