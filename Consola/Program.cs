using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Consola{
    class Program{
        private static int op=0;
        private static IRMunicipio objMunicipio = new RMunicipio(new Persistencia.AppContext());
        static void Main(string[] args){

            //Console.WriteLine("hOLA Maskdaj");
            Municipio municipio = new Municipio();
            municipio.Nombre="Medellin";
            bool ex=objMunicipio.CrearMunicipio(municipio);
            //var mun=objMunicipio.EliminarMunicipio(1);
            //Console.WriteLine(municipio.Id+" "+municipio.Nombre);

            if(ex){
                Console.WriteLine("Creado el municipio {0}",municipio.Nombre);
            }else{
                Console.WriteLine("No Creado");
            }
            //Console.WriteLine("Desea borrar el Municipio {0}?",muni.Nombre);
            //op=int.Parse(Console.ReadLine());
            //if(op==1){
              //  objMunicipio.EliminarMunicipio(muni.Id);
            //}
        }
    }
}
