﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220913224910_Primera")]
    partial class Primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Dominio.Arbitro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("ColegioInstruccionId")
                        .HasColumnType("int");

                    b.Property<string>("Deporte")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Rh")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int?>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColegioInstruccionId");

                    b.HasIndex("TorneoId");

                    b.ToTable("Arbitros");
                });

            modelBuilder.Entity("Dominio.ColegioInstruccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Deporte")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Licencia")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("ColegiosInstrucciones");
                });

            modelBuilder.Entity("Dominio.Deportista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Deporte")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Eps")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Rh")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Deportistas");
                });

            modelBuilder.Entity("Dominio.Entrenador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Deporte")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId")
                        .IsUnique();

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Jugadores")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("PatrocinadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatrocinadorId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Dominio.Escenario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Espectadores")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("UnidadDeportivaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnidadDeportivaId");

                    b.ToTable("Escenarios");
                });

            modelBuilder.Entity("Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Dominio.Patrocinador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Deporte")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("Personeria")
                        .HasMaxLength(30)
                        .HasColumnType("bit");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Patrocinadores");
                });

            modelBuilder.Entity("Dominio.Torneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CantidadEquipos")
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Deporte")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Etapa")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaIncio")
                        .HasColumnType("datetime2");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("PatrocinadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("PatrocinadorId");

                    b.ToTable("Torneos");
                });

            modelBuilder.Entity("Dominio.TorneoEquipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int?>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("TorneoId");

                    b.ToTable("TorneoEquipos");
                });

            modelBuilder.Entity("Dominio.UnidadDeportiva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int?>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TorneoId");

                    b.ToTable("UnidadesDeportivas");
                });

            modelBuilder.Entity("Dominio.Arbitro", b =>
                {
                    b.HasOne("Dominio.ColegioInstruccion", "Colegio")
                        .WithMany("Arbitros")
                        .HasForeignKey("ColegioInstruccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Torneo", "Torneo")
                        .WithMany("Arbitros")
                        .HasForeignKey("TorneoId");

                    b.Navigation("Colegio");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("Dominio.Deportista", b =>
                {
                    b.HasOne("Dominio.Equipo", "equipo")
                        .WithMany("Deportistas")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("equipo");
                });

            modelBuilder.Entity("Dominio.Entrenador", b =>
                {
                    b.HasOne("Dominio.Equipo", "equipo")
                        .WithOne("Tecnico")
                        .HasForeignKey("Dominio.Entrenador", "EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("equipo");
                });

            modelBuilder.Entity("Dominio.Equipo", b =>
                {
                    b.HasOne("Dominio.Patrocinador", "patrocinador")
                        .WithMany("Equipos")
                        .HasForeignKey("PatrocinadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("patrocinador");
                });

            modelBuilder.Entity("Dominio.Escenario", b =>
                {
                    b.HasOne("Dominio.UnidadDeportiva", null)
                        .WithMany("Escenarios")
                        .HasForeignKey("UnidadDeportivaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Torneo", b =>
                {
                    b.HasOne("Dominio.Municipio", "municipio")
                        .WithMany("Torneos")
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Patrocinador", "patrocinador")
                        .WithMany("Torneos")
                        .HasForeignKey("PatrocinadorId");

                    b.Navigation("municipio");

                    b.Navigation("patrocinador");
                });

            modelBuilder.Entity("Dominio.TorneoEquipo", b =>
                {
                    b.HasOne("Dominio.Equipo", "Equipo")
                        .WithMany("TorneosEquipo")
                        .HasForeignKey("EquipoId");

                    b.HasOne("Dominio.Torneo", "Torneo")
                        .WithMany("TorneoEquipos")
                        .HasForeignKey("TorneoId");

                    b.Navigation("Equipo");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("Dominio.UnidadDeportiva", b =>
                {
                    b.HasOne("Dominio.Torneo", "torneo")
                        .WithMany("UnidadesDeportivas")
                        .HasForeignKey("TorneoId");

                    b.Navigation("torneo");
                });

            modelBuilder.Entity("Dominio.ColegioInstruccion", b =>
                {
                    b.Navigation("Arbitros");
                });

            modelBuilder.Entity("Dominio.Equipo", b =>
                {
                    b.Navigation("Deportistas");

                    b.Navigation("Tecnico")
                        .IsRequired();

                    b.Navigation("TorneosEquipo");
                });

            modelBuilder.Entity("Dominio.Municipio", b =>
                {
                    b.Navigation("Torneos");
                });

            modelBuilder.Entity("Dominio.Patrocinador", b =>
                {
                    b.Navigation("Equipos");

                    b.Navigation("Torneos");
                });

            modelBuilder.Entity("Dominio.Torneo", b =>
                {
                    b.Navigation("Arbitros");

                    b.Navigation("TorneoEquipos");

                    b.Navigation("UnidadesDeportivas");
                });

            modelBuilder.Entity("Dominio.UnidadDeportiva", b =>
                {
                    b.Navigation("Escenarios");
                });
#pragma warning restore 612, 618
        }
    }
}
