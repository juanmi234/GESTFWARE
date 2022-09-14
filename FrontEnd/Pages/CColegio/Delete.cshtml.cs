using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace FrontEnd.Pages.CColegio
{
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IRColegioInstruccion objColegio;
        [BindProperty]
        public ColegioInstruccion colegio {get;set;}
        //Metodos
        //Constructor
        public DeleteModel(IRColegioInstruccion _objColegio){
            this.objColegio = _objColegio;
        }
        public ActionResult OnGet(int id){
            colegio=objColegio.BuscarColegio(id);
            if(colegio==null){
                //Entonces no se encontró el colegio, aunque no deberia pasar
                ViewData["Error"]="No se encontró el Colegio";
            }
            return Page();
        }
        public ActionResult OnPost(){
            if(objColegio.EliminarColegio(colegio.Id)){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"]="No se pudo eliminar este Colegio";
                return Page();
            }
            return Page();
        }
    }
}
