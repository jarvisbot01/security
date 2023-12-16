﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(SecurityContext))]
    [Migration("20231218224939_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb3_general_ci")
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb3");

            modelBuilder.Entity("Domain.Entities.CategoriaPer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("categoriaPer", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<int>("IdDepartamento")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_departamento");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdDepartamento" }, "fk_departamento");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ContactoPer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_persona");

                    b.Property<int>("IdTipoContacto")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_tipo_contacto");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPersona" }, "fk_persona_contacto");

                    b.HasIndex(new[] { "IdTipoContacto" }, "fk_tipo_contacto_contacto");

                    b.ToTable("contactoPer", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<DateOnly>("FechaContrato")
                        .HasColumnType("date")
                        .HasColumnName("fecha_contrato");

                    b.Property<DateOnly>("FechaFin")
                        .HasColumnType("date")
                        .HasColumnName("fecha_fin");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_cliente");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_empleado");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_estado");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCliente" }, "fk_cliente_contrato");

                    b.HasIndex(new[] { "IdEmpleado" }, "fk_empleado_contrato");

                    b.HasIndex(new[] { "IdEstado" }, "fk_estado_contrato");

                    b.ToTable("contrato", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<int>("IdPais")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_pais");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPais" }, "fk_pais");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DirPersona", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_persona");

                    b.Property<int>("IdTipoDireccion")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_tipo_direccion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPersona" }, "fk_persona_direccion");

                    b.HasIndex(new[] { "IdTipoDireccion" }, "fk_tipo_direccion_direccion");

                    b.ToTable("dirPersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("estado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime")
                        .HasColumnName("fechaRegistro");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_categoria");

                    b.Property<int>("IdCiudad")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_ciudad");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_persona");

                    b.Property<int>("IdTipoPersona")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_tipo_persona");

                    b.Property<string>("Nombre")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCategoria" }, "fk_categoria_persona");

                    b.HasIndex(new[] { "IdCiudad" }, "fk_ciudad_persona");

                    b.HasIndex(new[] { "IdTipoPersona" }, "fk_tipo_persona_persona");

                    b.HasIndex(new[] { "IdPersona" }, "id_persona")
                        .IsUnique();

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Programacion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<int>("IdContrato")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_contrato");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_empleado");

                    b.Property<int>("IdTurno")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_turno");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdContrato" }, "fk_contrato_programacion");

                    b.HasIndex(new[] { "IdEmpleado" }, "fk_persona_programacion");

                    b.HasIndex(new[] { "IdTurno" }, "fk_turno_programacion");

                    b.ToTable("programacion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoContacto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tipoContacto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoDireccion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tipoDireccion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tipoPersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Turno", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<TimeOnly>("HoraTurnoFin")
                        .HasColumnType("time")
                        .HasColumnName("hora_turno_fin");

                    b.Property<TimeOnly>("HoraTurnoInicio")
                        .HasColumnType("time")
                        .HasColumnName("hora_turno_inicio");

                    b.Property<string>("NombreTurno")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nombre_turno");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("turno", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "IdDepartamentoNavigation")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamento")
                        .IsRequired()
                        .HasConstraintName("fk_departamento");

                    b.Navigation("IdDepartamentoNavigation");
                });

            modelBuilder.Entity("Domain.Entities.ContactoPer", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "IdPersonaNavigation")
                        .WithMany("ContactoPers")
                        .HasForeignKey("IdPersona")
                        .IsRequired()
                        .HasConstraintName("fk_persona_contacto");

                    b.HasOne("Domain.Entities.TipoContacto", "IdTipoContactoNavigation")
                        .WithMany("ContactoPers")
                        .HasForeignKey("IdTipoContacto")
                        .IsRequired()
                        .HasConstraintName("fk_tipo_contacto_contacto");

                    b.Navigation("IdPersonaNavigation");

                    b.Navigation("IdTipoContactoNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Contrato", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "IdClienteNavigation")
                        .WithMany("ContratoIdClienteNavigations")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("fk_cliente_contrato");

                    b.HasOne("Domain.Entities.Persona", "IdEmpleadoNavigation")
                        .WithMany("ContratoIdEmpleadoNavigations")
                        .HasForeignKey("IdEmpleado")
                        .IsRequired()
                        .HasConstraintName("fk_empleado_contrato");

                    b.HasOne("Domain.Entities.Estado", "IdEstadoNavigation")
                        .WithMany("Contratos")
                        .HasForeignKey("IdEstado")
                        .IsRequired()
                        .HasConstraintName("fk_estado_contrato");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdEmpleadoNavigation");

                    b.Navigation("IdEstadoNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "IdPaisNavigation")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPais")
                        .IsRequired()
                        .HasConstraintName("fk_pais");

                    b.Navigation("IdPaisNavigation");
                });

            modelBuilder.Entity("Domain.Entities.DirPersona", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "IdPersonaNavigation")
                        .WithMany("DirPersonas")
                        .HasForeignKey("IdPersona")
                        .IsRequired()
                        .HasConstraintName("fk_persona_direccion");

                    b.HasOne("Domain.Entities.TipoDireccion", "IdTipoDireccionNavigation")
                        .WithMany("DirPersonas")
                        .HasForeignKey("IdTipoDireccion")
                        .IsRequired()
                        .HasConstraintName("fk_tipo_direccion_direccion");

                    b.Navigation("IdPersonaNavigation");

                    b.Navigation("IdTipoDireccionNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.HasOne("Domain.Entities.CategoriaPer", "IdCategoriaNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdCategoria")
                        .IsRequired()
                        .HasConstraintName("fk_categoria_persona");

                    b.HasOne("Domain.Entities.Ciudad", "IdCiudadNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdCiudad")
                        .IsRequired()
                        .HasConstraintName("fk_ciudad_persona");

                    b.HasOne("Domain.Entities.TipoPersona", "IdTipoPersonaNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersona")
                        .IsRequired()
                        .HasConstraintName("fk_tipo_persona_persona");

                    b.Navigation("IdCategoriaNavigation");

                    b.Navigation("IdCiudadNavigation");

                    b.Navigation("IdTipoPersonaNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Programacion", b =>
                {
                    b.HasOne("Domain.Entities.Contrato", "IdContratoNavigation")
                        .WithMany("Programacions")
                        .HasForeignKey("IdContrato")
                        .IsRequired()
                        .HasConstraintName("fk_contrato_programacion");

                    b.HasOne("Domain.Entities.Persona", "IdEmpleadoNavigation")
                        .WithMany("Programacions")
                        .HasForeignKey("IdEmpleado")
                        .IsRequired()
                        .HasConstraintName("fk_persona_programacion");

                    b.HasOne("Domain.Entities.Turno", "IdTurnoNavigation")
                        .WithMany("Programacions")
                        .HasForeignKey("IdTurno")
                        .IsRequired()
                        .HasConstraintName("fk_turno_programacion");

                    b.Navigation("IdContratoNavigation");

                    b.Navigation("IdEmpleadoNavigation");

                    b.Navigation("IdTurnoNavigation");
                });

            modelBuilder.Entity("Domain.Entities.CategoriaPer", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Contrato", b =>
                {
                    b.Navigation("Programacions");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Navigation("Contratos");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Navigation("ContactoPers");

                    b.Navigation("ContratoIdClienteNavigations");

                    b.Navigation("ContratoIdEmpleadoNavigations");

                    b.Navigation("DirPersonas");

                    b.Navigation("Programacions");
                });

            modelBuilder.Entity("Domain.Entities.TipoContacto", b =>
                {
                    b.Navigation("ContactoPers");
                });

            modelBuilder.Entity("Domain.Entities.TipoDireccion", b =>
                {
                    b.Navigation("DirPersonas");
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Turno", b =>
                {
                    b.Navigation("Programacions");
                });
#pragma warning restore 612, 618
        }
    }
}