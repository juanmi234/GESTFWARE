using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{
    public class Municipio
    {

        //Métodos
        /*Constructor estos métodos se hacen
        manualmente originalmente pero c# tiene una forma resumida de usarlos
        public Municipio()
        {}
        public void setId(int id)
        {
            this.Id=id;
        }
        public void getId()
        {
            return this.Id;
        }
        public void setNombre(string nombre)
        {
            this.Nombre=nombre;
        }
        public void getNombre()
        {
            return this.Nombre;
        }*/
        //Trabajo real por medio de propiedades

        public int Id { get; set; }
        
        [Required(ErrorMessage = "Este campo es obligatorio ")]
        [MaxLength(30, ErrorMessage = "El campo {0} es máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage = "El campo {0} es mínimo de {1} caracteres")]
        public string Nombre { get; set; }
    }
}