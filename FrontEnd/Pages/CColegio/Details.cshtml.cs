using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace FrontEnd.Pages.CColegio
{
    public class DetailsModel : PageModel
    {
        //Atributos
        private readonly IRColegioInstruccion objColegio;
        public ColegioInstruccion colegio;
        //Metodos
        //Constructor por defecto
        public DetailsModel(IRColegioInstruccion _objColegio){
            this.objColegio = _objColegio;
        }
        public ActionResult OnGet(int id)
        {
            colegio = objColegio.BuscarColegio(id);
            if(colegio==null){
                ViewData["Error"]="No se ha encontrado el Colegio";
                return Page();
            }
            return Page();
        }
    }
}
