using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CDeportista
{
    public class IndexModel : PageModel
    {
        //Atributos
        private readonly IRDeportista _repoDeportista;
        public IEnumerable<Deportista> Deportista {get;set;}

        //Metodos
        //Constructor
        public IndexModel(IRDeportista repoDeportista)
        {
            this._repoDeportista = repoDeportista;
        }

        //Enivar vistas y/o valores  al usuario 
        public void OnGet()
        {
            Deportista =_repoDeportista.ListarDeportistaIE();
        }
    }
}
