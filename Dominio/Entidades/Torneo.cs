using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio{
    public class Torneo{
        public int Id {get;set;}

        //Requerimientos para campo nombre
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(60,ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} debe tener mínimo de {1} caracteres")]
        public string Nombre {get;set;}

        //Requerimientos para campo categoria
        [Required(ErrorMessage="Este campo es obligatorio")]
        public string Categoria {get;set;}

        //Requerimientos para campo Deporte
        [Required(ErrorMessage="Este campo es obligatorio")]
        public string Deporte {get;set;}

        //Requerimiento para campo FechaInicio
        [Required(ErrorMessage="Este campo es obligatorio")]
        public DateTime FechaIncio {get;set;}

        //Requerimiento para campo FechaFin
        [Required(ErrorMessage="Este campo es obligatorio")]
        public DateTime FechaFin {get;set;}

        //Requerimientos para el campo CantidadEquipos
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int CantidadEquipos {get;set;}
        public string Etapa {get;set;}
        public int MunicipioId {get;set;}
        //Llave foranea
        public int PatrocinadorId {get;set;}
        //Llave foranea
        public List<Arbitro> Arbitros {get;set;}
        //public List<TorneoEquipo> TorneoEquipos {get;set;}
        public List<UnidadDeportiva> UnidadesDeportivas {get;set;}
    }
}