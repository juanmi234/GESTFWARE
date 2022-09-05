using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistencia{

    public class RDeportista:IRDeportista{
        //Atributos
        private readonly AppContext appContext;
        private static Deportista deportista;

        //Constructor por defecto
        public RDeportista(AppContext _appContext){
            this.appContext=_appContext;
        }
        public bool CrearDeportista(Deportista depor){
            if(!Existencia(depor)){
                try{
                    this.appContext.Deportistas.Add(depor);
                    this.appContext.SaveChanges();
                    return true;
                }catch(System.Exception){
                    return false;
                }
            }
            return false;
        }

        //Buscar Deportista
        public Deportista BuscarDeportista(string Documento){
            deportista=this.appContext.Deportistas.Find(Documento);
            return deportista;

        }

        //Eliminar Deportista
        public bool EliminarDeportista(int id){
            deportista=this.appContext.Deportistas.Find(id);
            if(deportista!=null){
                try
                {
                    this.appContext.Deportistas.Remove(deportista);
                    this.appContext.SaveChanges();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
            }
            return false;
        }

        //Listar Deportista
        public List<Deportista> ListarDeportistaList(){
            return this.appContext.Deportistas.ToList();
        }
        public IEnumerable<Deportista> ListarDeportistaIE(){
            return this.appContext.Deportistas;
        }   

        //Validar existencia
        private bool Existencia(Deportista depor){
            deportista=this.appContext.Deportistas.FirstOrDefault(
                        d=>d.Id==depor.Id);
            if(deportista!=null){
                //El deportista si existe
                return true;
            }
            return false;
        }
    }
}