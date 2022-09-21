using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio{
    public class Equipo{
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(25, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*)", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Nombre {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z0-9 ]*)", ErrorMessage="Ingrese valores validos")]
        public string Deporte {get;set;}

        [Required(ErrorMessage="Un equipo debe tener un técnico")]
        public Entrenador Tecnico {get;set;} 

        [Required(ErrorMessage="Este campo es obligatorio")]
        [RegularExpression("[0-9]*",ErrorMessage="Solo puede ingresar valores numericos")]
        
        public int Jugadores {get;set;}

        [Required(ErrorMessage="Un equipo debe estar patrocinado por al menos una marca")]
        public int PatrocinadorId {get;set;}
        public Patrocinador patrocinador {get;set;}//Propiedad navigacional
        //Llave foranea
        public List<TorneoEquipo> TorneosEquipo {get;set;}=new List<TorneoEquipo>();//Para relacion muchos a muchos
        public List<Deportista> Deportistas {get;set;} = new List<Deportista>();
    }
}
    
