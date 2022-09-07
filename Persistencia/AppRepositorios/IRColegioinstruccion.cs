using Dominio;
using System.Collections.Generic;

//Interfaz de Colegio Instruccion
namespace Persistencia{
    public interface IRColegioInstruccion{
        public bool CrearColegio(ColegioInstruccion colegio);
        public ColegioInstruccion BuscarColegio(string Nit);
        public bool ModificarColegio(ColegioInstruccion colegio);
        public bool EliminarColegio(string Nit);
        public List<ColegioInstruccion> ListarColegiosList();
        public IEnumerable<ColegioInstruccion> ListarColegiosIE();
    }
}