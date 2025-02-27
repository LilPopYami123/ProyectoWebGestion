﻿// <auto-generated />
using System;
using ManagmentApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManagmentApplication.Migrations
{
    [DbContext(typeof(MiContexto))]
    partial class MiContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ManagmentApplication.Models.ArchivosAdjunto", b =>
                {
                    b.Property<int>("IdArchivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdArchivo"));

                    b.Property<DateTime?>("FechaSubida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdTarea")
                        .HasColumnType("int");

                    b.Property<string>("NombreArchivo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RutaArchivo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdArchivo")
                        .HasName("PK__Archivos__26B92111B803CA4E");

                    b.HasIndex("IdTarea");

                    b.ToTable("ArchivosAdjuntos");
                });

            modelBuilder.Entity("ManagmentApplication.Models.Comentario", b =>
                {
                    b.Property<int>("IdComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdComentario"));

                    b.Property<string>("Comentario1")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Comentario");

                    b.Property<DateTime?>("Fecha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdTarea")
                        .HasColumnType("int");

                    b.HasKey("IdComentario")
                        .HasName("PK__Comentar__DDBEFBF95DFEA25A");

                    b.HasIndex("IdTarea");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("ManagmentApplication.Models.HistorialCambio", b =>
                {
                    b.Property<int>("IdCambio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCambio"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("Fecha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdProyecto")
                        .HasColumnType("int");

                    b.HasKey("IdCambio")
                        .HasName("PK__Historia__B4BBA86E9882E207");

                    b.HasIndex("IdProyecto");

                    b.ToTable("HistorialCambios");
                });

            modelBuilder.Entity("ManagmentApplication.Models.Participante", b =>
                {
                    b.Property<int>("IdParticipante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdParticipante"));

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("IdParticipante")
                        .HasName("PK__Particip__561392428C072274");

                    b.HasIndex(new[] { "Correo" }, "UQ__Particip__60695A194FEDC0A9")
                        .IsUnique();

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("ManagmentApplication.Models.Prioridade", b =>
                {
                    b.Property<int>("IdPrioridad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrioridad"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdPrioridad")
                        .HasName("PK__Priorida__0FC70DD54B1183DF");

                    b.ToTable("Prioridades");
                });

            modelBuilder.Entity("ManagmentApplication.Models.Proyecto", b =>
                {
                    b.Property<int>("IdProyecto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProyecto"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Pendiente");

                    b.Property<DateTime?>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("FechaFinEstimada")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdProyecto")
                        .HasName("PK__Proyecto__F48886738FAA9485");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("ManagmentApplication.Models.StatusProyecto", b =>
                {
                    b.Property<int>("IdStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdStatus"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdStatus")
                        .HasName("PK__StatusPr__B450643A2D3399BD");

                    b.ToTable("StatusProyectos");
                });

            modelBuilder.Entity("ManagmentApplication.Models.Tarea", b =>
                {
                    b.Property<int>("IdTarea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTarea"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("Pendiente");

                    b.Property<DateTime?>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdProyecto")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("TiempoEsperado")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal?>("TiempoRealizado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10, 2)")
                        .HasDefaultValue(0m);

                    b.HasKey("IdTarea")
                        .HasName("PK__Tareas__EADE909801234857");

                    b.HasIndex("IdProyecto");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("ParticipantesTarea", b =>
                {
                    b.Property<int>("IdParticipante")
                        .HasColumnType("int");

                    b.Property<int>("IdTarea")
                        .HasColumnType("int");

                    b.HasKey("IdParticipante", "IdTarea")
                        .HasName("PK__Particip__C8BE7B4B227558C8");

                    b.HasIndex("IdTarea");

                    b.ToTable("ParticipantesTareas", (string)null);
                });

            modelBuilder.Entity("TareasPrioridade", b =>
                {
                    b.Property<int>("IdTarea")
                        .HasColumnType("int");

                    b.Property<int>("IdPrioridad")
                        .HasColumnType("int");

                    b.HasKey("IdTarea", "IdPrioridad")
                        .HasName("PK__TareasPr__AA22E0453ADEE865");

                    b.HasIndex("IdPrioridad");

                    b.ToTable("TareasPrioridades", (string)null);
                });

            modelBuilder.Entity("ManagmentApplication.Models.ArchivosAdjunto", b =>
                {
                    b.HasOne("ManagmentApplication.Models.Tarea", "IdTareaNavigation")
                        .WithMany("ArchivosAdjuntos")
                        .HasForeignKey("IdTarea")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__ArchivosA__IdTar__628FA481");

                    b.Navigation("IdTareaNavigation");
                });

            modelBuilder.Entity("ManagmentApplication.Models.Comentario", b =>
                {
                    b.HasOne("ManagmentApplication.Models.Tarea", "IdTareaNavigation")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdTarea")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Comentari__IdTar__5EBF139D");

                    b.Navigation("IdTareaNavigation");
                });

            modelBuilder.Entity("ManagmentApplication.Models.HistorialCambio", b =>
                {
                    b.HasOne("ManagmentApplication.Models.Proyecto", "IdProyectoNavigation")
                        .WithMany("HistorialCambios")
                        .HasForeignKey("IdProyecto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Historial__IdPro__66603565");

                    b.Navigation("IdProyectoNavigation");
                });

            modelBuilder.Entity("ManagmentApplication.Models.Tarea", b =>
                {
                    b.HasOne("ManagmentApplication.Models.Proyecto", "IdProyectoNavigation")
                        .WithMany("Tareas")
                        .HasForeignKey("IdProyecto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Tareas__IdProyec__52593CB8");

                    b.Navigation("IdProyectoNavigation");
                });

            modelBuilder.Entity("ParticipantesTarea", b =>
                {
                    b.HasOne("ManagmentApplication.Models.Participante", null)
                        .WithMany()
                        .HasForeignKey("IdParticipante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Participa__IdPar__5812160E");

                    b.HasOne("ManagmentApplication.Models.Tarea", null)
                        .WithMany()
                        .HasForeignKey("IdTarea")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Participa__IdTar__59063A47");
                });

            modelBuilder.Entity("TareasPrioridade", b =>
                {
                    b.HasOne("ManagmentApplication.Models.Prioridade", null)
                        .WithMany()
                        .HasForeignKey("IdPrioridad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__TareasPri__IdPri__6C190EBB");

                    b.HasOne("ManagmentApplication.Models.Tarea", null)
                        .WithMany()
                        .HasForeignKey("IdTarea")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__TareasPri__IdTar__6B24EA82");
                });

            modelBuilder.Entity("ManagmentApplication.Models.Proyecto", b =>
                {
                    b.Navigation("HistorialCambios");

                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("ManagmentApplication.Models.Tarea", b =>
                {
                    b.Navigation("ArchivosAdjuntos");

                    b.Navigation("Comentarios");
                });
#pragma warning restore 612, 618
        }
    }
}
