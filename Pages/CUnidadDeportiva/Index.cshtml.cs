using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CUnidadDeportiva
{
    public class IndexModel : PageModel
    {
        //Atributos
        private readonly IRUnidadDeportiva _repoUnidadDeportiva;
        public IEnumerable<UnidadDeportiva> UnidadesDeportivas {get;set;}

        //Metodos
        //Constructor
        public IndexModel(IRUnidadDeportiva repoUnidadDeportiva)
        {
            this._repoUnidadDeportiva=repoUnidadDeportiva;
        }

        //Enivar vistas y/o valores  al usuario 
        public void OnGet()
        {
            UnidadesDeportivas=_repoUnidadDeportiva.ListarUniDeportivaIE();
        }
    }
}
