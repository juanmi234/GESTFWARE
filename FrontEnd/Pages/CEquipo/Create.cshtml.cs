using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.CEquipo
{
    public class CreateModel : PageModel
    {
        //Atributos
        private readonly IREquipo objEquipo;
        private readonly IREntrenador objEntrenador;
        public Equipo equipo {get;set;}
        public IEnumerable<Entrenador> lstEntrenadores {get;set;}
        //Metodo Constructor por defecto
        public CreateModel(IREquipo _objEquipo,IREntrenador _objEntrenador){
            this.objEquipo = _objEquipo;
            this.objEntrenador = _objEntrenador;
        }
        public ActionResult OnGet(){
            lstEntrenadores=objEntrenador.ListarEntrenadorIE();
            return Page();
        }
        public ActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }
            if(objEquipo.CrearEquipo(equipo)){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"]="Ya existe un equipo con este mismo nombre\n"+
                                    "O ya hay un equipo con ese mismo entrenador";
                return Page();
            }
        }
    }
}
