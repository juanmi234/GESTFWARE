using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.CMunicipio
{
    public class EditModel : PageModel
    {
        //Atributos
        private readonly IRMunicipio objMunicipio;
        public Municipio municipio {get;set;}
        public void OnGet()
        {
        }
    }
}
