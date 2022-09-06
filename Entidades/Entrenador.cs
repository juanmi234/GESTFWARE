using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio{
    public class Entrenador{
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([0-9]+)", ErrorMessage="El campo {0} solo acepta valores numericos")]
        public string Documento {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        public string Nombres {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        public string Apellidos {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        public string Deporte {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([0-9]+)", ErrorMessage="El campo {0} solo acepta valores numericos")]
        public string Celular {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        public string Correo {get;set;}
        
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int EquipoId {get;set;}
    }
}
