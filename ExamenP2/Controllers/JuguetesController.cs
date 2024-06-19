using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ExamenP2;

public class JuguetesController : Controller
{
    private readonly ApplicationDBContext _context;
    public JuguetesController(ApplicationDBContext context)
    {
        _context = context;
    }
    
    
    public IActionResult JuguetesList()
    {

       List<Juguetes> JuguetesList = _context.Juguetes.Select(e => new Juguetes()
        {
            idJuguetes = e.idJuguetes,
            Codigo = e.Codigo,
            Nombre = e.Nombre,
            Precio = e.Precio,
            Vigencia = e.Vigencia,
            Activo = e.Activo
        }).ToList();

        return View(JuguetesList);
    }


    [HttpGet]
    public IActionResult JuguetesAdd (Guid idJuguetes)
    {
        JuguetesModel juguetesNew = new JuguetesModel();
        juguetesNew.idJuguetes = Guid.NewGuid();





         

        return View(juguetesNew);
    }


    [HttpPost]
    public async Task<IActionResult> JuguetesAdd (Juguetes juguetes)
    {
        
        if (ModelState.IsValid)
        {
            _context.Add(juguetes);
            await _context.SaveChangesAsync();
            await _context.SaveChangesAsync();

            return RedirectToAction("JuguetesList", "Juguetes");
        }


         return View(juguetes);

    }

    public IActionResult EmpleadosUpdate (Guid idJuguetes)
    {
        Juguetes? juguetes = this._context.Juguetes
        .Where(p=> p.idJuguetes == idJuguetes).FirstOrDefault();

        if (juguetes == null)
        {
            return RedirectToAction("EmpleadosList", "Empleados");
        }

        

        JuguetesModel juguetesUpdate = new JuguetesModel();
        juguetesUpdate.idJuguetes = juguetes.idJuguetes;
        
        
        return View(juguetesUpdate);
    }

    [HttpPost]
    public IActionResult EmpleadosUpdate (JuguetesModel juguetes)
    {
        Juguetes juguetesEntidad = this._context.Juguetes
        .Where(p=> p.idJuguetes == juguetes.idJuguetes).First();

        if (juguetesEntidad == null)
        {
            return View(juguetes);
        }

        juguetesEntidad.Nombre = juguetes.nombreJuguetes;
        
        juguetesEntidad.Precio = juguetes.Precio;

        this._context.Juguetes.Update(juguetesEntidad);
        this._context.SaveChanges();
        return RedirectToAction("JuguetesList", "Juguetes");


    }

    
}