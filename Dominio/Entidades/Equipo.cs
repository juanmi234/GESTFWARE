using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio{
    public class Equipo{
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(25, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Nombre {get;set;}
        //public List<string> Deporte {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        public Entrenador Tecnico {get;set;} 


        [Required(ErrorMessage="Este campo es obligatorio")]
        [RegularExpression("[0-9]*",ErrorMessage="Solo puede ingresar valores numericos")]
        
        public int Jugadores {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        public int PatrocinadorId {get;set;}


        public List<TorneoEquipo> TorneoEquipos {get;set;}


        public List<Deportista> Deportistas {get;set;}
    }
}