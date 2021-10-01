﻿// <auto-generated />
using System;
using GanaderiaWeb.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GanaderiaWeb.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GanaderiaWeb.App.Dominio.LoteGanado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CantidadCebuino")
                        .HasColumnType("int");

                    b.Property<int>("CantidadCriollo")
                        .HasColumnType("int");

                    b.Property<int>("CantidadEjemplares")
                        .HasColumnType("int");

                    b.Property<int>("CantidadTaurino")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdGanadero")
                        .HasColumnType("int");

                    b.Property<int>("Total1a2Anios")
                        .HasColumnType("int");

                    b.Property<int>("Total2a3Anios")
                        .HasColumnType("int");

                    b.Property<int>("TotalHembras")
                        .HasColumnType("int");

                    b.Property<int>("TotalMachos")
                        .HasColumnType("int");

                    b.Property<int>("TotalMas3Anios")
                        .HasColumnType("int");

                    b.Property<int>("TotalMenos1Anio")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LotesGanado");
                });

            modelBuilder.Entity("GanaderiaWeb.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("GanaderiaWeb.App.Dominio.Ganadero", b =>
                {
                    b.HasBaseType("GanaderiaWeb.App.Dominio.Persona");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Ganadero");
                });
#pragma warning restore 612, 618
        }
    }
}
