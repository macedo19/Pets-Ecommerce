﻿// <auto-generated />
using System;
using EcommerceAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EcommerceAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211127000336_AlteracaoBanco")]
    partial class AlteracaoBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EcommerceAPI.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("NomePet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeTutor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Porte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("EcommerceAPI.Models.Horarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Hora")
                        .HasColumnType("int");

                    b.Property<int>("Horario")
                        .HasColumnType("int");

                    b.Property<int>("HorarioMarcado")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("EcommerceAPI.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CPF")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hora")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}
