using Dominio; //Lo hago así para sólo importar la del paquete dominio la clase Arbitro
using System.Collections.Generic;

namespace Persistencia{
    public interface IRArbitro{ //IR significa Interfaz tonxs InterfazdeArbitro
        //Metodos CRUD
        public bool CrearArbitro(Arbitro arbitro);
        public Arbitro BuscarArbitro(string documento);
        public bool ModificarArbitro(Arbitro arbitro);
        public bool EliminarArbitro(string documento);
        public List<Arbitro> ListarArbitros_List();
        public IEnumerable<Arbitro> ListarArbitros_IEnumerable();
    }
}