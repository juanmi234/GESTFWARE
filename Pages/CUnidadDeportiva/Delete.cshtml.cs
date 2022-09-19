using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CUnidadDeportiva
{
    public class DeleteModel : PageModel
    {
        //Atributos
        private readonly IRUnidadDeportiva _repoUnidadDeportiva;

        [BindProperty]
        public UnidadDeportiva UnidadDeportiva { get; set; }

        //Metodos
        //Constructor

        public DeleteModel(IRUnidadDeportiva repoUnidadDeportiva)
        {
            this._repoUnidadDeportiva=repoUnidadDeportiva;
        }

        //enviar informacion al formulario
        public ActionResult OnGet(int Id)
        {
            UnidadDeportiva= _repoUnidadDeportiva.BuscarUniDeportiva(Id);
            if(UnidadDeportiva== null)
            {
                ViewData["Error"]="Unidad no encontrada";
                return Page();
            }
            return Page();
        }

        public ActionResult OnPost()
        {
            bool funciono= _repoUnidadDeportiva.EliminarUniDeportiva(UnidadDeportiva.Id);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"]="No es posible eliminar registros con integridad referencial, verificar en la lista de equipos";
                return Page();
            }
        }
    }
}
