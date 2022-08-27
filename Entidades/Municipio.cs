using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//IMPORTANTE IMPORTAR ESTOS DOS ULTIMOS
//Son los encargados de hacer que el Required y otras funciones sirvan

namespace Dominio{
    public class Municipio{
        public int Id {get;set;}

        //Estos son los requerimientos de los campos 
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        public string Nombre{get;set;}
        public List<Torneo> Torneos {get;set;}
    }
}