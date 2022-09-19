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
    public class EditModel : PageModel
    {
        private readonly IREscenario _repoEscenario;

        [BindProperty]
        public Escenario Escenario { get; set; }

        public EditModel(IREscenario repoEscenario)
        {
            this._repoEscenario =repoEscenario;
        }

        public ActionResult OnGet(int id)
        {
            Escenario = _repoEscenario.BuscarEscenario(id);
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            bool funciono= _repoEscenario.ActualizarEscenario(Escenario);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"]="No fue posible actualizar el registro";
                return Page();
            }
        }
    }
}