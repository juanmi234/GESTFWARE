using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistencia{
    public interface IRDeportista{
        public bool CrearDeportista(Deportista deportista);
        public Deportista BuscarDeportista(string Documento);
        public bool EliminarDeportista(int id);
        public List<Deportista> ListarDeportistaList();
        public IEnumerable<Deportista> ListarDeportistaIE();

    }
}