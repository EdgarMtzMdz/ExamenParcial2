﻿// <auto-generated />
using System;
using ExamenP2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamenP2.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240619014503_Juguetes")]
    partial class Juguetes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamenP2.Juguetes", b =>
                {
                    b.Property<Guid>("idJuguetes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<DateTime>("Vigencia")
                        .HasColumnType("datetime2");

                    b.HasKey("idJuguetes");

                    b.ToTable("Juguetes");
                });

            modelBuilder.Entity("ExamenP2.Marca", b =>
                {
                    b.Property<Guid>("idMarca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("codigoMarca")
                        .HasColumnType("int");

                    b.Property<string>("nombreMarca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMarca");

                    b.ToTable("Marca");
                });
#pragma warning restore 612, 618
        }
    }
}
