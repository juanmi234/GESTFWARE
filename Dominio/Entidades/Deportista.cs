using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio{
    public class Deportista{
        public int Id {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([0-9]+)", ErrorMessage="El campo {0} solo acepta valores numericos")]
        public string Documento {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*)", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Nombres {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*)", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Apellidos {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(12, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*)", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Genero {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z0-9 ]*)", ErrorMessage="Ingrese valores validos")]
        public string Deporte {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(3, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(1, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        public string Rh {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(3, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [RegularExpression("([A-Za-z ]*)", ErrorMessage="El campo {0} no acepta valores numericos")]
        public string Eps {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(15, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        [Range(3000000000,3509999999, ErrorMessage="El campo {0} solo acepta valores numericos")]
        public string Celular {get;set;}

        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage="El campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage="El campo {0} debe tener minimo {1} caracteres")]
        public string Correo {get;set;}

        //LLAVES FORANEAS
        [Required(ErrorMessage="Un deportista debe esta en un equipo")]
        public int EquipoId {get;set;}//Relacion con tabla Equipo
        public Equipo equipo {get;set;}//Propiedad navigacional

        //Metodos
        //Calcular edad
        public int CalcularEdad(){
            DateTime fechaActual = DateTime.Today;
            int yearActual= fechaActual.Year;
            int anios = yearActual-this.FechaNacimiento.Year;
            return anios;
        }

    }
}