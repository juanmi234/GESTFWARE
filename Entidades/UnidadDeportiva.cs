using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio{
    public class UnidadDeportiva{
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        public string Nombre {get;set;}
        
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        public string Direccion {get;set;}
        
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        public string Ciudad {get;set;}
        public List<Escenario> Escenarios {get;set;}
        
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int TorneoId {get;set;}

    }
}
