using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExamenP2;

public class JuguetesModel
{
    public JuguetesModel()
    {
    }

    public Guid idJuguetes { get; set; }
    public int Codigo { get; set; }
    public string nombreJuguetes { get; set; }
    public int Precio { get; set; }
    public DateTime Vigencia { get; set; }
    public bool Activo { get; set; }

   
    
    
    
    
}