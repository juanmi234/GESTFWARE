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
    public class EditModel : PageModel
    {
        private readonly IRUnidadDeportiva _repoUnidadDeportiva;

        [BindProperty]
        public UnidadDeportiva UnidadDeportiva { get; set; }

        public EditModel(IRUnidadDeportiva repoUnidadDeportiva)
        {
            this._repoUnidadDeportiva =repoUnidadDeportiva;
        }

        public ActionResult OnGet(int id)
        {
            UnidadDeportiva = _repoUnidadDeportiva.BuscarUniDeportiva(id);
            return Page();
        }

        public ActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            bool funciono= _repoUnidadDeportiva.ModificarUniDeportiva(UnidadDeportiva);
            if(funciono)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                ViewData["Error"]="No fue posible actualizar el registro";
                return Page();
            }
        }
    }
}