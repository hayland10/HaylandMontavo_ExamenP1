﻿// <auto-generated />
using System;
using HaylandMontavo_ExamenP1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HaylandMontavo_ExamenP1.Migrations
{
    [DbContext(typeof(HaylandMontavo_ExamenP1Context))]
    partial class HaylandMontavo_ExamenP1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HaylandMontavo_ExamenP1.Models.HaylandMontalvo_tabla", b =>
                {
                    b.Property<int>("IdMonster")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMonster"), 1L, 1);

                    b.Property<DateTime>("hmDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("hmNombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("hmNumeroMonsters")
                        .HasColumnType("int");

                    b.Property<decimal>("hmPrecio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("hmPrimeraVez")
                        .HasColumnType("bit");

                    b.HasKey("IdMonster");

                    b.ToTable("HaylandMontalvo_tabla");
                });
#pragma warning restore 612, 618
        }
    }
}
