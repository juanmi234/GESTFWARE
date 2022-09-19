using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CEscenario
{
    public class DetailsModel : PageModel
    {
        //Atributos
        private readonly IREscenario _repoEscenario;

        [BindProperty]
        public Escenario Escenario {get;set;}

        //Metodos
        //Constructor
        public DetailsModel(IREscenario repoEscenario)
        {
            this._repoEscenario = repoEscenario;
        }

        public ActionResult OnGet(int id)
        {
            Escenario= _repoEscenario.BuscarEscenario(id);
            return Page();
        }
    }
}
