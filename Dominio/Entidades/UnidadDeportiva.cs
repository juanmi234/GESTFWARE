namespace Dominio{
    public class UnidadDeportiva{
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Direccion {get;set;}
        public string Ciudad {get;set;}
        public List<Escenario> Escenarios {get;set;}
        public int TorneoId {get;set;}
        //Llave foranea

    }
}