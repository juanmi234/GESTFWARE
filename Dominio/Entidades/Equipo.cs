using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio{
    public class Equipo{
        [Required(ErrorMessage="Este campo es obligatorio")]
        public int Id {get;set;}

        //Requerimientos campo Nombre
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(25)]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        public string Nombre {get;set;}
        //public List<string> Deporte {get;set;}

        [Required(ErrorMessage="Un equipo debe tener un técnico")]
        public Entrenador Tecnico {get;set;} 
        //Este no aparece en la base de datos mega F

        //Requerimientos campo Jugadores
        [Required(ErrorMessage="Este campo es obligatorio")]
        [Range(0, 1000000000,ErrorMessage="Ingrese un valor correcto")]
        public int Jugadores {get;set;}
        
        //Requerimientos campo PatrocinadorId
        [Required(ErrorMessage="Un equipo debe estar patrocinado por al menos una marca")]
        public int PatrocinadorId {get;set;}
        //Llave foranea
        public List<TorneoEquipo> TorneosEquipo {get;}=new List<TorneoEquipo>();//Para relacion muchos a muchos
        public List<Deportista> Deportistas {get;} = new List<Deportista>();
    }
}