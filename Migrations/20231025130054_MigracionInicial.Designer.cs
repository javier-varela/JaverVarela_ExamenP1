﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JaverVarela_ExamenP1.Migrations
{
    [DbContext(typeof(JaverVarela_ExamenP1Context))]
    [Migration("20231025130054_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JaverVarela_ExamenP1.Models.JavierVarela_tabla", b =>
                {
                    b.Property<int>("JVId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JVId"), 1L, 1);

                    b.Property<string>("JVDescripcion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("JVFecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("JVIsTrue")
                        .HasColumnType("bit");

                    b.Property<decimal>("JVNota")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("JVId");

                    b.ToTable("JavierVarela_tabla");
                });
#pragma warning restore 612, 618
        }
    }
}
