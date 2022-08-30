using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia{
    public class RArbitro:IRArbitro{ //Esta clase "RArbitro" debe implementar el IRArbitro
        //Atributo
        private readonly AppContext appContext;
        //Se hace de tipo AppContext porque ahí es donde se manipula la base de datos

        //Metodos
        //Constructor por defecto
        public RArbitro(AppContext _appContext){
            this.appContext=_appContext;
        }
        public bool CrearArbitro(Arbitro arbitro){
            try{
                this.appContext.Arbitros.Add(arbitro);
                this.appContext.SaveChanges();
                return true;
            }catch(System.Exception){
                //Adicionar un mensajito
                return false;
            }
        }
        public Arbitro BuscarArbitro(string documento){
            Arbitro arbitro = new Arbitro();
            return arbitro;
        }
        public bool ModificarArbitro(Arbitro arbitro){
            return true;
        }
        public bool EliminarArbitro(string documento){
            return true;
        }
        public List<Arbitro> ListarArbitros_List(){
            return this.appContext.Arbitros.ToList();
        }
        public IEnumerable<Arbitro> ListarArbitros_IEnumerable(){
            return this.appContext.Arbitros;
        }
    }
}