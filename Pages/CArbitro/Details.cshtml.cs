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
        //Para la propiedad navigacional
        private readonly IRTorneo objTorneo;
        //Para la propiedad navigacional
        private readonly IRColegioInstruccion objColegio;
        public Arbitro arbitro;
        //Para las propiedades navigacionales
        public ColegioInstruccion colegio;
        public Torneo torneo;
        //Metodos
        //Constructor por defecto
        public DetailsModel(IRArbitro _objArbitro,IRColegioInstruccion _objColegio, IRTorneo _objTorneo){
            this.objArbitro = _objArbitro;
            this.objColegio = _objColegio;
            this.objTorneo = _objTorneo;
        }
        public ActionResult OnGet(int id){
            arbitro = objArbitro.BuscarArbitro(id);
            colegio = objColegio.BuscarColegio(arbitro.ColegioInstruccionId);
            if(arbitro==null){
                ViewData["Error"]="No se encontró el Arbitro";
                return Page();
            }else{
                if(arbitro.TorneoId!=null){
                    torneo = objTorneo.BuscarTorneo(int.Parse(""+arbitro.TorneoId));
                    return Page();
                }
            }
            return Page();
        }
    }
}
