using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.CArbitro
{
    public class DetailsModel : PageModel
    {
        //Atributos
        private readonly IRArbitro objArbitro;
        public Arbitro arbitro;
        //Metodos
        //Constructor por defecto
        public DetailsModel(IRArbitro _objArbitro){
            this.objArbitro = _objArbitro;
        }
        public ActionResult OnGet(int id){
            arbitro = objArbitro.BuscarArbitro(id);
            if(arbitro==null){
                ViewData["Error"]="No se encontró el Arbitro";
                return Page();
            }
            return Page();
        }
    }
}
