using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.CPatrocinador
{
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IRPatrocinador objPatrocinador;
        [BindProperty]
        public Patrocinador patrocinador {get;set;}
        //Metodo Constructor por defecto
        public DeleteModel(IRPatrocinador _objPatrocinador){
            this.objPatrocinador = _objPatrocinador;
        }
        public ActionResult OnGet(int id)//Capturado en el Index
        {
            patrocinador=objPatrocinador.BuscarPatrocinador(id);
            if(patrocinador==null){
                //Esto no debería pasar
                ViewData["Error"]="No se encontró el patrocinador";
                return Page();
            }
            return Page();
        }
        public ActionResult OnPost(){
            if(objPatrocinador.EliminarPatrocinador(patrocinador.Id)){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"]="No fue posible eliminar este registro"+
                                    "Quizás hayan muchos equipos y torneos relacionados con este patrocinador"+
                                    "Si se borrase, se borrarian los equipos y torneos en donde este este patrocinador";
                return Page();
            }
        }
    }
}
