﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnicFormatos.Models;

namespace unicformatos.Migrations
{
    [DbContext(typeof(CareerContext))]
    partial class CareerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("UnicFormatos.Models.Inscripcion", b =>
                {
                    b.Property<long>("Matricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Generacion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Licenciatura")
                        .HasColumnType("TEXT");

                    b.Property<string>("Semestre")
                        .HasColumnType("TEXT");

                    b.HasKey("Matricula");

                    b.ToTable("Inscripcion");
                });

            modelBuilder.Entity("UnicFormatos.Models.Inscripcion", b =>
                {
                    b.OwnsOne("UnicFormatos.Models.Emergencia", "Emergencia", b1 =>
                        {
                            b1.Property<long>("InscripcionMatricula")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("TipoSangre")
                                .HasColumnType("TEXT");

                            b1.HasKey("InscripcionMatricula");

                            b1.ToTable("Inscripcion");

                            b1.WithOwner()
                                .HasForeignKey("InscripcionMatricula");

                            b1.OwnsOne("UnicFormatos.Models.Familiar", "Contacto", b2 =>
                                {
                                    b2.Property<long>("EmergenciaInscripcionMatricula")
                                        .HasColumnType("INTEGER");

                                    b2.Property<string>("Domicilio")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("Empresa")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("Nombre")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("Parentesco")
                                        .HasColumnType("TEXT");

                                    b2.HasKey("EmergenciaInscripcionMatricula");

                                    b2.ToTable("Inscripcion");

                                    b2.WithOwner()
                                        .HasForeignKey("EmergenciaInscripcionMatricula");

                                    b2.OwnsOne("UnicFormatos.Models.Contacto", "Contacto", b3 =>
                                        {
                                            b3.Property<long>("FamiliarEmergenciaInscripcionMatricula")
                                                .HasColumnType("INTEGER");

                                            b3.Property<string>("Email")
                                                .HasColumnType("TEXT");

                                            b3.Property<string>("TelCelular")
                                                .HasColumnType("TEXT");

                                            b3.Property<string>("TelParticular")
                                                .HasColumnType("TEXT");

                                            b3.HasKey("FamiliarEmergenciaInscripcionMatricula");

                                            b3.ToTable("Inscripcion");

                                            b3.WithOwner()
                                                .HasForeignKey("FamiliarEmergenciaInscripcionMatricula");
                                        });
                                });
                        });

                    b.OwnsOne("UnicFormatos.Models.Familiar", "Madre", b1 =>
                        {
                            b1.Property<long>("InscripcionMatricula")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Domicilio")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Empresa")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Nombre")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Parentesco")
                                .HasColumnType("TEXT");

                            b1.HasKey("InscripcionMatricula");

                            b1.ToTable("Inscripcion");

                            b1.WithOwner()
                                .HasForeignKey("InscripcionMatricula");

                            b1.OwnsOne("UnicFormatos.Models.Contacto", "Contacto", b2 =>
                                {
                                    b2.Property<long>("FamiliarInscripcionMatricula")
                                        .HasColumnType("INTEGER");

                                    b2.Property<string>("Email")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("TelCelular")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("TelParticular")
                                        .HasColumnType("TEXT");

                                    b2.HasKey("FamiliarInscripcionMatricula");

                                    b2.ToTable("Inscripcion");

                                    b2.WithOwner()
                                        .HasForeignKey("FamiliarInscripcionMatricula");
                                });
                        });

                    b.OwnsOne("UnicFormatos.Models.Familiar", "Padre", b1 =>
                        {
                            b1.Property<long>("InscripcionMatricula")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Domicilio")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Empresa")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Nombre")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Parentesco")
                                .HasColumnType("TEXT");

                            b1.HasKey("InscripcionMatricula");

                            b1.ToTable("Inscripcion");

                            b1.WithOwner()
                                .HasForeignKey("InscripcionMatricula");

                            b1.OwnsOne("UnicFormatos.Models.Contacto", "Contacto", b2 =>
                                {
                                    b2.Property<long>("FamiliarInscripcionMatricula")
                                        .HasColumnType("INTEGER");

                                    b2.Property<string>("Email")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("TelCelular")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("TelParticular")
                                        .HasColumnType("TEXT");

                                    b2.HasKey("FamiliarInscripcionMatricula");

                                    b2.ToTable("Inscripcion");

                                    b2.WithOwner()
                                        .HasForeignKey("FamiliarInscripcionMatricula");
                                });
                        });

                    b.OwnsOne("UnicFormatos.Models.Inscripcion_Domicilio", "Domicilio", b1 =>
                        {
                            b1.Property<long>("InscripcionMatricula")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Calle")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Colonia")
                                .HasColumnType("TEXT");

                            b1.Property<long>("Cp")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Estado")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Municipio")
                                .HasColumnType("TEXT");

                            b1.Property<long>("Numero")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Poblacion")
                                .HasColumnType("TEXT");

                            b1.HasKey("InscripcionMatricula");

                            b1.ToTable("Inscripcion");

                            b1.WithOwner()
                                .HasForeignKey("InscripcionMatricula");
                        });

                    b.OwnsOne("UnicFormatos.Models.Personal", "Personal", b1 =>
                        {
                            b1.Property<long>("InscripcionMatricula")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("ApMaterno")
                                .HasColumnType("TEXT");

                            b1.Property<string>("ApPaterno")
                                .HasColumnType("TEXT");

                            b1.Property<string>("LugarNacimiento")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Nacionalidad")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Nombre")
                                .HasColumnType("TEXT");

                            b1.HasKey("InscripcionMatricula");

                            b1.ToTable("Inscripcion");

                            b1.WithOwner()
                                .HasForeignKey("InscripcionMatricula");

                            b1.OwnsOne("UnicFormatos.Models.Contacto", "Contacto", b2 =>
                                {
                                    b2.Property<long>("PersonalInscripcionMatricula")
                                        .HasColumnType("INTEGER");

                                    b2.Property<string>("Email")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("TelCelular")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("TelParticular")
                                        .HasColumnType("TEXT");

                                    b2.HasKey("PersonalInscripcionMatricula");

                                    b2.ToTable("Inscripcion");

                                    b2.WithOwner()
                                        .HasForeignKey("PersonalInscripcionMatricula");
                                });

                            b1.OwnsOne("UnicFormatos.Models.FechaNacimiento", "FechaNacimiento", b2 =>
                                {
                                    b2.Property<long>("PersonalInscripcionMatricula")
                                        .HasColumnType("INTEGER");

                                    b2.Property<long>("Day")
                                        .HasColumnType("INTEGER");

                                    b2.Property<long>("Month")
                                        .HasColumnType("INTEGER");

                                    b2.Property<long>("Year")
                                        .HasColumnType("INTEGER");

                                    b2.HasKey("PersonalInscripcionMatricula");

                                    b2.ToTable("Inscripcion");

                                    b2.WithOwner()
                                        .HasForeignKey("PersonalInscripcionMatricula");
                                });
                        });

                    b.OwnsOne("UnicFormatos.Models.Trabajo", "Trabajo", b1 =>
                        {
                            b1.Property<long>("InscripcionMatricula")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Nombre")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Telefono")
                                .HasColumnType("TEXT");

                            b1.HasKey("InscripcionMatricula");

                            b1.ToTable("Inscripcion");

                            b1.WithOwner()
                                .HasForeignKey("InscripcionMatricula");

                            b1.OwnsOne("UnicFormatos.Models.TrabajoDomicilio", "Domicilio", b2 =>
                                {
                                    b2.Property<long>("TrabajoInscripcionMatricula")
                                        .HasColumnType("INTEGER");

                                    b2.Property<string>("Calle")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("Colonia")
                                        .HasColumnType("TEXT");

                                    b2.Property<string>("Municipio")
                                        .HasColumnType("TEXT");

                                    b2.Property<long>("Numero")
                                        .HasColumnType("INTEGER");

                                    b2.HasKey("TrabajoInscripcionMatricula");

                                    b2.ToTable("Inscripcion");

                                    b2.WithOwner()
                                        .HasForeignKey("TrabajoInscripcionMatricula");
                                });
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
