using System.Transactions;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.CEquipo
{
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IREquipo objEquipo;
        private readonly IRPatrocinador objPatrocinador;
        private readonly IREntrenador objEntrenador;
        [BindProperty]
        public Equipo equipo {get;set;}
        public Patrocinador patrocinador {get;set;}
        public Entrenador entrenador {get;set;}
        //Constructor
        public DeleteModel(IREquipo _objEquipo,IRPatrocinador _objPatrocinador,IREntrenador _objEntrenador){
            this.objEquipo = _objEquipo;
            this.objPatrocinador = _objPatrocinador;
            this.objEntrenador = _objEntrenador;
        }
        public ActionResult OnGet(int id){
            equipo = objEquipo.BuscarEquipo(id);
            if(equipo==null){
                ViewData["Error"]="No se encontró el equipo";
                return Page();
            }else{
                patrocinador = objPatrocinador.BuscarPatrocinador(equipo.PatrocinadorId);
                if(equipo.Tecnico!=null){
                    entrenador = objEntrenador.BuscarEntrenador(equipo.Id);
                }else{
                    ViewData["Error"]="No detecto tecnico";
                }
                return Page();
            }
        }
        public ActionResult OnPost(){
            if(objEquipo.EliminarEquipo(equipo.Id)){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"]="No fue posible eliminar este registro";
                return Page();
            }
        }
    }
}