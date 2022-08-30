using System.Collections.Generic;
namespace Dominio{
    public class Equipo{
        public int Id {get;set;}
        public string Nombre {get;set;}
        //public List<string> Deporte {get;set;}
        public Entrenador Tecnico {get;set;}  
        //Este no aparece en la base de datos mega F
        public int Jugadores {get;set;}
        public int PatrocinadorId {get;set;}
        //Llave foranea
        public List<TorneoEquipo> TorneoEquipos {get;set;}
        public List<Deportista> Deportistas {get;set;}
    }
}