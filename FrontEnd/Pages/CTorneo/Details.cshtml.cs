using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
namespace FrontEnd.Pages.CTorneo
{
    public class DetailsModel : PageModel
    {
        //Atributos
        private readonly IRTorneo objTorneo;
        private readonly IRPatrocinador objPatrocinador;
        private readonly IRMunicipio objMunicipio;
        public Torneo torneo {get;set;}
        public Patrocinador patrocinador {get;set;}
        public Municipio municipio {get;set;}
        //Metodos
        //Constructor
        public DetailsModel(IRTorneo _objTorneo,IRPatrocinador _objPatrocinador,IRMunicipio _objMunicipio){
            this.objTorneo = _objTorneo;
            this.objPatrocinador = _objPatrocinador;
            this.objMunicipio = _objMunicipio;
        }
        
        public ActionResult OnGet(int id){   
            torneo=objTorneo.BuscarTorneo(id);
            if(torneo!=null){
                municipio=objMunicipio.BuscarMunicipio(torneo.MunicipioId);
                if(torneo.PatrocinadorId!=null){
                    patrocinador=objPatrocinador.BuscarPatrocinador(int.Parse(""+torneo.PatrocinadorId));
                }
                return Page();
            }else{
                ViewData["Error"]="No se encontro el Torneo";
                return Page();
            }
        }
    }
}
