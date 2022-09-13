using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio
{
    public class Patrocinador
    {
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        [RegularExpression("([0-9]*", ErrorMessage="El campo {0} solo acepta valores numericos")]
        public string Documento {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(35, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Nombres {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        [RegularExpression("([A-Za-z0-9 ]*", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Deporte {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        public string Direccion {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        [Range(3000000000,3509999999, ErrorMessage="El campo {0} solo acepta valores numericos")]
        public string Telefono {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Ciudad {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        public bool Personeria {get;set;}
        //Para las relaciones
        public List<Equipo> Equipos {get;set;}=new List<Equipo>();
        public List<Torneo> Torneos {get;set;}=new List<Torneo>();
    }
}