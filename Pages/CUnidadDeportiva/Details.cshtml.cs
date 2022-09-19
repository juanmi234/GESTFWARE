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
    public class DetailsModel : PageModel
    {
        //Atributos
        private readonly IRUnidadDeportiva _repoUnidadDeportiva;

        [BindProperty]
        public UnidadDeportiva UnidadDeportiva {get;set;}

        //Metodos
        //Constructor
        public DetailsModel(IRUnidadDeportiva repoUnidadDeportiva)
        {
            this._repoUnidadDeportiva= repoUnidadDeportiva;
        }

        public ActionResult OnGet(int id)
        {
            UnidadDeportiva= _repoUnidadDeportiva.BuscarUniDeportiva(id);
            return Page();
        }
    }
}
