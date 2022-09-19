using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CColegio
{
    public class CreateModel : PageModel
    {
        // Atributos
        private readonly IRColegio _repoColegio;

        [BindProperty]
        public Colegio Colegio { get; set; }

        //Metodos
        //Constructor
        public CreateModel(IRColegio repoColegio)
        {
            this._repoColegio= repoColegio;
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
            bool funciono= _repoColegio.CrearColegio(Colegio);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"]= "No puede crear Municipios con nombres repetidos";
                return Page();
            }
        }
    }
}
