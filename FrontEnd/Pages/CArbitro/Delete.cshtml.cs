using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace FrontEnd.Pages.CArbitro
{
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IRArbitro objArbitro;
        public Arbitro arbitro;
        //Metodos
        //Constructor
        public DeleteModel(IRArbitro _objArbitro){
            this.objArbitro = _objArbitro;
        }
        public ActionResult OnGet(int id){
            arbitro=objArbitro.BuscarArbitro(id);
            if(arbitro==null){
                ViewData["Error"]="No se encontró el Arbitro";
                return Page();
            }
            return Page();
        }
    }
}
