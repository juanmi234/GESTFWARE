using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CEscenario
{
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IREscenario _repoEscenario;

        [BindProperty]
        public Escenario Escenario { get; set; }

        //Metodos
        //Constructor

        public DeleteModel(IREscenario repoEscenario)
        {
            this._repoEscenario = repoEscenario;
        }

        //enviar informacion al formulario
        public ActionResult OnGet(int id)
        {
            Escenario= _repoEscenario.BuscarEscenario(id);
            if(Escenario== null)
            {
                ViewData["Error"]="Unidad no encontrada";
                return Page();
            }
            return Page();
        }

        public ActionResult OnPost()
        {
            bool funciono= _repoEscenario.EliminarEscenario(Escenario.Id);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"]="No es posible eliminar registros con integridad referencial, verificar en la lista de equipos";
                return Page();
            }
        }
    }
}
