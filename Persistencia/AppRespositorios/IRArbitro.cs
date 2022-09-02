using Dominio;
using System.Collections.Generic;
//Interfaz Arbitro
namespace Persistencia{
    public interface IRArbitro{ //IR significa Interfaz tonxs InterfazdeArbitro
    //También debe siempre ser public interface
        //Metodos CRUD
        public bool CrearArbitro(Arbitro arbitro);
        public Arbitro BuscarArbitro(string documento);
        public bool ModificarArbitro(Arbitro arbitro);
        public bool EliminarArbitro(string documento);
        public List<Arbitro> ListarArbitrosList();
        public IEnumerable<Arbitro> ListarArbitrosIE();
    }
}