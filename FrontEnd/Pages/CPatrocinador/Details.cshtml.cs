using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.CPatrocinador
{
    public class DetailsModel : PageModel
    {
        //Atributos
        private readonly IRPatrocinador objPatrocinador;
        public Patrocinador patrocinador {get;set;}
        //Metodo Constructor por defecto
        public DetailsModel(IRPatrocinador _objPatrocinador){
            this.objPatrocinador = _objPatrocinador;
        }
        public ActionResult OnGet(int id)//id capturado en el index
        {
            patrocinador = objPatrocinador.BuscarPatrocinador(id);
            if(patrocinador==null){
                //Esto no debería pasar
                ViewData["Error"]="No se encontró el Patrocinador";
                return Page();
            }
            return Page();
        }
    }
}
