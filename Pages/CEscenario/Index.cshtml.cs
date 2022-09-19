using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using System.Collections.Generic;

namespace Frontend.Pages.CEscenario
{
    public class IndexModel : PageModel
    {
        //Atributos
        private readonly IREscenario _repoEscenario;
        public IEnumerable<Escenario> Escenarios { get; set; }

        //Metodos
        //Constructor
        public IndexModel(IREscenario repoEscenario)
        {
            this._repoEscenario = repoEscenario;
        }

        //Enivar vistas y/o valores  al usuario 
        public void OnGet()
        {
            Escenarios = _repoEscenario.ListarEscenarioIE();
        }
    }
}

