using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio{
    public class Escenario{
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*)", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Nombre {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [Range(0, 1000000000,ErrorMessage="Ingrese un valor correcto")]
        public int Espectadores {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z0-9 ]*)", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Tipo {get;set;}

        [Required(ErrorMessage="El escenario debe pertenecer a una Unidad Deportiva")]
        public int UnidadDeportivaId {get;set;}
    }
}