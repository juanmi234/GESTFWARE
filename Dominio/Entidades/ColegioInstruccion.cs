namespace Dominio{
    public class ColegioInstruccion{
        public int Id {get;set;}
        public string Nit {get;set;}
        public string RazonSocial {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public string Deporte {get;set;}
        public string Licencia {get;set;}
        public List<Arbitro> Arbitros {get;set;}
    }
}