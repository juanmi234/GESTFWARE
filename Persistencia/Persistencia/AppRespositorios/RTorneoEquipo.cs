using System;
using Dominio;
using System.Linq;
using System.Collections.Generic;

namespace Persistencia{
    public class RTorenoEquipo:IRTorneoEquipo{
        //Atributos
        private readonly AppContext appContext;
        private static TorneoEquipo torneoEquipo;
        //Constructor por defecto
        public RTorenoEquipo(AppContext _appContext){
            this.appContext = _appContext;
        }
        //Metodos CRUD
        public bool CrearTorneoEquipo(TorneoEquipo torneoEquipo){
            try{
                this.appContext.TorneoEquipos.Add(torneoEquipo);
                this.appContext.SaveChanges();
                return true;
            }catch(System.Exception){
                return false;
            }
        }
        public IEnumerable<TorneoEquipo> ListarTorneoEquipoIE(){
            return this.appContext.TorneoEquipos;
        }
        public List<TorneoEquipo> ListarTorneoEquipoList(){
            return this.appContext.TorneoEquipos.ToList();
        }
    }
}