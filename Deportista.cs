using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio{
    public class Deportista{
        public int Id {get;set;}

        //Requerimientos para campo Documento
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15)]
        [MinLength(7,ErrorMessage="El campo {0} debe tener mínimo {1} caracteres")]
        [RegularExpression("([0-9]+)",ErrorMessage="Digite solo numeros en este campo")]
        public string Documento {get;set;}

        //Requerimientos para campo Nombres
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30)]
        [MinLength(3,ErrorMessage="El campo {0} debe tener mínimo {1} caracteres")]
        public string Nombres {get;set;}

        //Requerimientos para campo Apellidos
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30)]
        [MinLength(3,ErrorMessage="El campo {0} debe tener mínimo {1} caracteres")]
        public string Apellidos {get;set;}

        //Requerimientos para campo Genero
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(10)]
        [MinLength(3,ErrorMessage="El campo {0} debe tener mínimo {1} caracteres")]
        [DataType(DataType.Text)]
        public string Genero {get;set;}

        //Requerimientos para campo Deporte
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(20)]
        [MinLength(4,ErrorMessage="El campo {0} debe tener mínimo {1} caracteres")]
        [DataType(DataType.Text)]
        public string Deporte {get;set;}

        //Requerimientos para campo FechaNacimiento
        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento {get;set;}

        //Requerimientos para campo RH
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(3)]
        [MinLength(1,ErrorMessage="El campo {0} debe tener mínimo {1} caracteres")]
        [DataType(DataType.Text)]
        public string Rh {get;set;}

        //Requerimientos campo Eps
        [MaxLength(30)]
        [MinLength(5,ErrorMessage="El campo {0} debe tener mínimo {1} caracteres")]
        [DataType(DataType.Text)]
        public string Eps {get;set;}

        //Requerimientos campo Celular
        [Required(ErrorMessage="Este campo es obligatio")]
        [MaxLength(15)]
        [MinLength(10,ErrorMessage="El campo {0} debe tener mínimo {1} caracteres")]
        [RegularExpression("([0-9]+)",ErrorMessage="Por favor digite solo números")]
        public string Celular {get;set;}

        //Requerimientos campo Correo
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40)]
        [MinLength(10,ErrorMessage="El campo {0} debe tener mínimo {1} caracteres")]
        public string Correo {get;set;}

        //LLAVES FORANEAS
        [Required(ErrorMessage="Un deportista debe esta en un equipo")]
        public int EquipoId {get;set;}
    }
}