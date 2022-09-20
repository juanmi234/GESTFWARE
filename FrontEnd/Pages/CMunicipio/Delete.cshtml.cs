using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.CMunicipio
{
    public class DeleteModel : PageModel{

        //Atributos
        private readonly IRMunicipio objMunicipio;

        public Municipio municipio {get;set;}

        //Metodos
        //Constructor
        public DeleteModel(IRMunicipio _objMunicipio){
            this.objMunicipio = _objMunicipio;
        }

        //Sirve para enviar información al formulario
        public ActionResult OnGet(int id)
        {
            municipio=objMunicipio.BuscarMunicipio(id);
            if(municipio==null){
                ViewData["Error"]="No se ha encontrado el municipio";
                return Page();
            }
            return Page();
        }
        public ActionResult OnPost(){
            if(objMunicipio.EliminarMunicipio(municipio.Id)){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"]="No fue posible eliminar este registro";
                return Page();
            }
        }
    }
}
