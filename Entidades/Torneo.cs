using System;
using System.Collections.Generic;

namespace Dominio{
    public class Torneo{
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Categoria {get;set;}
        public string Deporte {get;set;}
        public DateTime FechaIncio {get;set;}
        public DateTime FechaFin {get;set;}
        public int CantidadEquipos {get;set;}
        public string Etapa {get;set;}
        public List<Arbitro> Arbitros {get;set;}
        public List<TorneoEquipo> TorneoEquipos {get;set;}
        public List<UnidadDeportiva> UnidadesDeportivas {get;set;}
    }
}