﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace MotorcycleCompany.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entities.Models.Agency", b =>
                {
                    b.Property<Guid>("AgencyId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("AgencyId");

                    b.ToTable("Agency");

                    b.HasData(
                        new
                        {
                            AgencyId = new Guid("b1fe1869-335b-4e83-a45c-d6f88da0c620"),
                            Address = "Calle del recuerdo",
                            Location = "Usaquen",
                            Name = "Agencia01",
                            Neighborhood = "Santa Barbara"
                        },
                        new
                        {
                            AgencyId = new Guid("53096188-487a-4782-83dd-82b740bac892"),
                            Address = "Calle de la soledad",
                            Location = "Usaquen",
                            Name = "Agencia02",
                            Neighborhood = "Santa Ana"
                        });
                });

            modelBuilder.Entity("Entities.Models.City", b =>
                {
                    b.Property<Guid>("CityId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Department")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<int?>("Inhabitants")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("CityId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Entities.Models.Client", b =>
                {
                    b.Property<Guid>("ClientId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("E_Mail")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("E-Mail");

                    b.Property<string>("FistName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("TypeId")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientId = new Guid("52baaae1-1817-4057-8a29-2aa0af75c6d2"),
                            Address = "La calle del ocio",
                            E_Mail = "german.alarcon@misena.edu.co",
                            FistName = "German Gilberto",
                            LastName = "Alarcon R",
                            Number = "79802910",
                            Phone = "3153666036",
                            TypeId = "CC"
                        },
                        new
                        {
                            ClientId = new Guid("59972c0c-6a31-4419-8b27-cfedc48d4a49"),
                            Address = "La calle de la Melancolia",
                            E_Mail = "ana.yaqueline@misena.edu.co",
                            FistName = "Ana Yaqueline",
                            LastName = "Chavarro",
                            Number = "79802911",
                            Phone = "3153666037",
                            TypeId = "CC"
                        });
                });

            modelBuilder.Entity("Entities.Models.Garage", b =>
                {
                    b.Property<Guid>("GarageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<Guid>("CityId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("GarageId", "Address");

                    b.HasIndex("CityId");

                    b.ToTable("Garage");
                });

            modelBuilder.Entity("Entities.Models.Motorcycle", b =>
                {
                    b.Property<string>("MotorcycleId")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Chassis")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("DateOfEntry")
                        .HasColumnType("date");

                    b.Property<Guid>("GarageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("MotorcycleId");

                    b.HasIndex("GarageId", "Address");

                    b.ToTable("Motorcycle");
                });

            modelBuilder.Entity("Entities.Models.Phone", b =>
                {
                    b.Property<Guid>("AgencyId")
                        .HasColumnType("char(36)");

                    b.Property<string>("PhoneId")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("AgencyId", "PhoneId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("Entities.Models.Rent", b =>
                {
                    b.Property<Guid>("RentId")
                        .HasColumnType("char(36)");

                    b.Property<string>("MotorcycleId")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AgencyId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Paid")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime");

                    b.HasKey("RentId", "MotorcycleId", "ClientId", "AgencyId");

                    b.HasIndex("AgencyId");

                    b.HasIndex("ClientId");

                    b.HasIndex("MotorcycleId");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("Entities.Models.Garage", b =>
                {
                    b.HasOne("Entities.Models.City", "City")
                        .WithMany("Garages")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Entities.Models.Motorcycle", b =>
                {
                    b.HasOne("Entities.Models.Garage", "Garage")
                        .WithMany("Motorcycles")
                        .HasForeignKey("GarageId", "Address")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garage");
                });

            modelBuilder.Entity("Entities.Models.Phone", b =>
                {
                    b.HasOne("Entities.Models.Agency", "Agency")
                        .WithMany("Phones")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");
                });

            modelBuilder.Entity("Entities.Models.Rent", b =>
                {
                    b.HasOne("Entities.Models.Agency", "Agency")
                        .WithMany("Rents")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Client", "Client")
                        .WithMany("Rents")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Motorcycle", "Motorcycle")
                        .WithMany("Rents")
                        .HasForeignKey("MotorcycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("Client");

                    b.Navigation("Motorcycle");
                });

            modelBuilder.Entity("Entities.Models.Agency", b =>
                {
                    b.Navigation("Phones");

                    b.Navigation("Rents");
                });

            modelBuilder.Entity("Entities.Models.City", b =>
                {
                    b.Navigation("Garages");
                });

            modelBuilder.Entity("Entities.Models.Client", b =>
                {
                    b.Navigation("Rents");
                });

            modelBuilder.Entity("Entities.Models.Garage", b =>
                {
                    b.Navigation("Motorcycles");
                });

            modelBuilder.Entity("Entities.Models.Motorcycle", b =>
                {
                    b.Navigation("Rents");
                });
#pragma warning restore 612, 618
        }
    }
}
