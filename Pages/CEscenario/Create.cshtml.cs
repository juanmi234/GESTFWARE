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
    public class CreateModel : PageModel
    {
        // Atributos
        private readonly IREscenario _repoEscenario;

        [BindProperty]
        public Escenario Escenario { get; set; }

        //Metodos
        //Constructor
        public CreateModel(IREscenario repoEscenario)
        {
            this._repoEscenario = repoEscenario;
        }

        //enviar informacion o vista al usuario
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            bool funciono= _repoEscenario.CrearEscenario(Escenario);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"]= "No puede crear Unidades deportivas doble vez";
                return Page();
            }
        }
    }
}
