using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace Dominio{
    public class Torneo{
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*)", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Nombre {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        public string Categoria {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        [RegularExpression("([A-Za-z0-9 ]*)", ErrorMessage="Ingrese valores validos")]
        public string Deporte {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaFin {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [Range(0, 1000000000,ErrorMessage="Ingrese un valor correcto")]
        public int CantidadEquipos {get;set;}
        
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(10, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")]
        public string Etapa {get;set;}

        //LLAVES FORANEAS
        [Required(ErrorMessage="Escoga un Municipio donde se realizará el torneo")]
        public int MunicipioId {get;set;}
        public Municipio municipio {get;set;}

        public int? PatrocinadorId {get;set;}//Este creo puede ser nulo
        public Patrocinador patrocinador {get;set;}

        //Listas ya inicializadas
        public List<Arbitro> Arbitros {get;set;}=new List<Arbitro>();
        public List<TorneoEquipo> TorneoEquipos {get;set;}=new List<TorneoEquipo>(); //Para la relacion muchos a muchos
        public List<UnidadDeportiva> UnidadesDeportivas {get;set;}=new List<UnidadDeportiva>();
        
    }
}