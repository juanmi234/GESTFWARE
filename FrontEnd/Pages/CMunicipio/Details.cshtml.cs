using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.CMunicipio
{
    public class DetailsModel : PageModel{
        //Atributos
        private readonly IRMunicipio objMunicipio;
        public Municipio municipio {get;set;}

        //Metodos
        //Constructor
        public DetailsModel(IRMunicipio _objMunicipio){
            this.objMunicipio = _objMunicipio;
        }
        public ActionResult OnGet(int id){//Este int id siempre pide desde el index.cshtml, haciendo uso del asp-route-id = entidad.Id
            
            municipio=objMunicipio.BuscarMunicipio(id);
            if(municipio==null){
                ViewData["Error"]="No se encontrĂ³ el municipio";
                return Page();
            }
            return Page();
        }
    }
}
