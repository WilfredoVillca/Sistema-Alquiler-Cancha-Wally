﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_Alquiler_Cancha__Wally.Context;

#nullable disable

namespace Sistema_Alquiler_Cancha__Wally.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240609060938_PrimeraMigracion")]
    partial class PrimeraMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Sistema_Alquiler_Cancha__Wally.Models.Alquiler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CanchaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo_Total")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Desde")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Hasta")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero_Recibo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CanchaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Alquilers");
                });

            modelBuilder.Entity("Sistema_Alquiler_Cancha__Wally.Models.Cancha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacidad")
                        .HasMaxLength(5)
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Esta_Ocupado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero_Cancha")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("Sistema_Alquiler_Cancha__Wally.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ci")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Sistema_Alquiler_Cancha__Wally.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("Rol")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Sistema_Alquiler_Cancha__Wally.Models.Alquiler", b =>
                {
                    b.HasOne("Sistema_Alquiler_Cancha__Wally.Models.Cancha", "Cancha")
                        .WithMany("Alquilers")
                        .HasForeignKey("CanchaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sistema_Alquiler_Cancha__Wally.Models.Cliente", "Cliente")
                        .WithMany("Alquilers")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sistema_Alquiler_Cancha__Wally.Models.Usuario", "Usuario")
                        .WithMany("Alquilers")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cancha");

                    b.Navigation("Cliente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Sistema_Alquiler_Cancha__Wally.Models.Cancha", b =>
                {
                    b.Navigation("Alquilers");
                });

            modelBuilder.Entity("Sistema_Alquiler_Cancha__Wally.Models.Cliente", b =>
                {
                    b.Navigation("Alquilers");
                });

            modelBuilder.Entity("Sistema_Alquiler_Cancha__Wally.Models.Usuario", b =>
                {
                    b.Navigation("Alquilers");
                });
#pragma warning restore 612, 618
        }
    }
}
