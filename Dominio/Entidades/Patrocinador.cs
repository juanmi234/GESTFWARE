using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Patrocinador
    {
        public int Id {get;set;}
        public string Documento {get;set;}
        public string Nombres {get;set;}
        public string Deporte {get;set;}
        public string Direccion {get;set;}//Puede ser nulo
        public string Telefono {get;set;}
        public string Ciudad {get;set;}
        public bool Personeria {get;set;}
        public List<Equipo> Equipos {get;set;}
        public List<Torneo> Torneos {get;set;}
    }
}