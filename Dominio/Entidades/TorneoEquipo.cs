
namespace Dominio{
    public class TorneoEquipo{
        public int Id {get;set;}
        public int EquipoId {get;set;}
        public Equipo Equipo {get;set;}
        //public int TorneoId {get;set;}
        //public Torneo Torneo {get;set;}
        //NO deja crear esta entidad para la relacion muchos a muchos
    }
}