using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.CDeportista
{
    public class CreateModel : PageModel
    {
        //Atributos
        private readonly IRDeportista objDeportista;
        private readonly IREquipo objEquipo;
        [BindProperty]
        public Deportista deportista {get;set;}
        public IEnumerable<Equipo> equipo {get;set;}
        //Metodo constructor
        public CreateModel(IRDeportista _objDeportista,IREquipo _objEquipo){
            this.objDeportista = _objDeportista;
            this.objEquipo = _objEquipo;
        }

        public ActionResult OnGet()
        {
            return Page();
        }
        public ActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }
            if(objDeportista.CrearDeportista(deportista)){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"]="Ya existe un deportista con este mismo documento";
            }
        }
    }
}
