﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace practica8.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20241116013722_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Detenciones", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaD")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaN")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitud")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitud")
                        .HasColumnType("REAL");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Pasaporte")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("detenciones");
                });
#pragma warning restore 612, 618
        }
    }
}
