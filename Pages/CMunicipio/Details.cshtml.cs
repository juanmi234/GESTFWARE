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
        public ActionResult OnGet(int id){
            municipio=objMunicipio.BuscarMunicipio(id);
            if(municipio==null){
                ViewData["Error"]="No se encontró el municipio";
                return Page();
            }
            return Page();
        }
    }
}
