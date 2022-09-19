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
    public class IndexModel : PageModel
    {
        //Atributos que instancian un objeto de la interfaz
        private readonly IRColegio _repoColegio;
        //Como se esta trabajando con metodología de propiedades tiene sus métodos get y set
        public IEnumerable<Colegio> Colegios {get;set;} 

        //Metodos
        //Constructor
        public IndexModel(IRColegio repoColegio)
        {
            this._repoColegio=repoColegio; //_parámetro: es el parámetro propio del método
        }

        //Envía vistas y/o valores  al usuario 
        public void OnGet()
        {
            Colegios=_repoColegio.ListarColegiosIE();//Obtiene el listado de la clase IR
        }
    }
}