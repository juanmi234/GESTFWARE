using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Dominio{
    public class TorneoEquipo{
        public int Id {get;set;}
        public int EquipoId {get;set;}
        public int TorneoId {get;set;}
        public Torneo Torneo {get;set;}
        public Equipo Equipo {get;set;}
    }
}