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
        public string Nombre {get;set;}
        //public List<string> Deporte {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        public Entrenador Tecnico {get;set;} 

        //Este no aparece en la base de datos mega F

        [Required(ErrorMessage="Este campo es obligatorio")]
        [Range(0, 1000000000,ErrorMessage="Ingrese un valor correcto")]
        
        public int Jugadores {get;set;}


        public int PatrocinadorId {get;set;}


        public List<TorneoEquipo> TorneoEquipos {get;set;}


        public List<Deportista> Deportistas {get;set;}
    }
}