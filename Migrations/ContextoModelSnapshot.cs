﻿// <auto-generated />
using System;
using ControlVideoJuego.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControlVideoJuego.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("ControlVideoJuego.Entidades.Consolas", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<double>("Almacenamiento")
                        .HasColumnType("REAL");

                    b.Property<string>("Fabricante")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("PrecioRenta")
                        .HasColumnType("REAL");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("REAL");

                    b.Property<double>("Version")
                        .HasColumnType("REAL");

                    b.HasKey("Nombre");

                    b.ToTable("Consolas");
                });

            modelBuilder.Entity("ControlVideoJuego.Entidades.Juegos", b =>
                {
                    b.Property<int>("JuegoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fabricante")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Plataforma")
                        .HasColumnType("TEXT");

                    b.Property<double>("PrecioRenta")
                        .HasColumnType("REAL");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("REAL");

                    b.Property<string>("Tipo")
                        .HasColumnType("TEXT");

                    b.HasKey("JuegoId");

                    b.ToTable("Juegos");
                });
#pragma warning restore 612, 618
        }
    }
}