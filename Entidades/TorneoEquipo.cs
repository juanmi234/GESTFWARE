using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio{
    public class TorneoEquipo{
        //public int Id {get;set;}
        public int? EquipoId {get;set;}
        public Equipo Equipo {get;set;}
        public int? TorneoId {get;set;} 
        public Torneo Torneo {get;set;}
        //El ? es para decir que pueden tomar el valor null
    }
}
