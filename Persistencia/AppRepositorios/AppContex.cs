using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Dominio;
using System;
using System.Collections.Generic;

namespace Persistencia{
    public class AppContext:DbContext{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Eventos30");
            }
        }

    public DbSet<Municipio> Municipios {get;set;}
    public DbSet<Torneo> Torneos {get;set;}
    public DbSet<Equipo> Equipos {get;set;} 
    public DbSet<TorneoEquipo> TorneoEquipos {get;set;}
    public DbSet<Patrocinador> Patrocinadores {get;set;}
    public DbSet<Arbitro> Arbitros {get;set;}
    public DbSet<ColegioInstruccion> ColegiosInstrucciones {get;set;}
    public DbSet<UnidadDeportiva> UnidadesDeportivas {get;set;}
    public DbSet<Entrenador> Entrenadores {get;set;}
    public DbSet<Deportista> Deportistas {get;set;}
    public DbSet<Escenario> Escenarios {get;set;}


    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    //     {
    //         //Define una llave primaria compuesta
    //         modelBuilder.Entity<TorneoEquipo>().HasKey(x=>new {x.TorneoId,x.EquipoId});

    //         //Marcar un campo como unico
    //         modelBuilder.Entity<Torneo>().HasIndex(t => t.Nombre).IsUnique();
    //         modelBuilder.Entity<Municipio>().HasIndex(m => m.Nombre).IsUnique();
    //         modelBuilder.Entity<Equipo>().HasIndex(e => e.Nombre).IsUnique();
    //         modelBuilder.Entity<Entrenador>().HasIndex(ent => ent.Documento).IsUnique();

    //         //controlar eliminacion en cascada 
    //         modelBuilder.Entity<Patrocinador>()
    //                     .HasMany(p => p.Equipos)
    //                     .WithOne(e => e.PatrocinadorId)
    //                     .OnDelete(DeleteBehavior.Restrict);
    //     }

    

        /*Todo esto de arriba se hace para que la base de datos cree
        las tablas, ademas de servir para luego usarlas en los métodos CRUD
        */

        //Conectar con la base de datos

        //Atajo teclado para abrir la terminal: Ctrl+Shift+Ñ

        //Comando para crear la migracion, debe estar en el la carpeta de persistencia:
        //dotnet ef add migrations ElNombreQueQuiera

        //comando para que la migracion se refleje en microsoft sql, debe estar en la carpeta persistencia:
        //dotnet ef database update 

        //Comando para verificar errores en las capas cualquiera:
        //dotnet build

        //Comando para crear la Consola:
        //dotnet new console -o NombreQueLeQuieraPoner(usualmente es Consola)

        //Comando para correr la consola:
        //dotnet run 

    }   // crear una migracion nueva, debe estar en persistencia (actuaizar las migtraciones)
        // dotnet ef migrations add Primera --startup-project ..\Consola\

}