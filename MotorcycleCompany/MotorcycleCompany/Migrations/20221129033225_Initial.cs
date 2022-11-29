﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorcycleCompany.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Agency",
                columns: table => new
                {
                    AgencyId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Address = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Neighborhood = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agency", x => x.AgencyId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Department = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Inhabitants = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TypeId = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FistName = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMail = table.Column<string>(name: "E-Mail", type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    AgencyId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PhoneId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    NumberPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => new { x.AgencyId, x.PhoneId });
                    table.ForeignKey(
                        name: "FK_Phone_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "AgencyId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Garage",
                columns: table => new
                {
                    GarageId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Address = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CityId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garage", x => new { x.GarageId, x.Address });
                    table.ForeignKey(
                        name: "FK_Garage_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Motorcycle",
                columns: table => new
                {
                    MotorcycleId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Chassis = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Make = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfEntry = table.Column<DateTime>(type: "date", nullable: false),
                    GarageId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Address = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycle", x => x.MotorcycleId);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Garage_GarageId_Address",
                        columns: x => new { x.GarageId, x.Address },
                        principalTable: "Garage",
                        principalColumns: new[] { "GarageId", "Address" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    RentId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MotorcycleId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AgencyId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ReservationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RentalDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Paid = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => new { x.RentId, x.MotorcycleId, x.ClientId, x.AgencyId });
                    table.ForeignKey(
                        name: "FK_Rent_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "AgencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rent_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rent_Motorcycle_MotorcycleId",
                        column: x => x.MotorcycleId,
                        principalTable: "Motorcycle",
                        principalColumn: "MotorcycleId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Agency",
                columns: new[] { "AgencyId", "Address", "Location", "Name", "Neighborhood" },
                values: new object[,]
                {
                    { new Guid("ca7b62e0-6ffb-4e08-a60d-80bef78eaabe"), "Calle de la soledad", "Usaquen", "Agencia02", "Santa Ana" },
                    { new Guid("e5e71ebd-93fb-4b8c-8953-460ad2795087"), "Calle del recuerdo", "Usaquen", "Agencia01", "Santa Barbara" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "Department", "Inhabitants", "Name" },
                values: new object[,]
                {
                    { new Guid("857b63b1-3900-4765-9229-1bf3fe00e096"), "Bogota", 23, "Bogota" },
                    { new Guid("b887aba1-e002-49bf-b057-9e7cc7c5d8f3"), "Tusi", 21, "Medellin" }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Address", "E-Mail", "FistName", "LastName", "Number", "Phone", "TypeId" },
                values: new object[,]
                {
                    { new Guid("c67a8f75-e136-4de4-9c34-84ca95d83a78"), "La calle del ocio", "german.alarcon@misena.edu.co", "German Gilberto", "Alarcon R", "79802910", "3153666036", "CC" },
                    { new Guid("fa519d95-072d-4f39-81f4-75d1d6f3c515"), "La calle de la Melancolia", "ana.yaqueline@misena.edu.co", "Ana Yaqueline", "Chavarro", "79802911", "3153666037", "CC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Garage_CityId",
                table: "Garage",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_GarageId_Address",
                table: "Motorcycle",
                columns: new[] { "GarageId", "Address" });

            migrationBuilder.CreateIndex(
                name: "IX_Rent_AgencyId",
                table: "Rent",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_ClientId",
                table: "Rent",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_MotorcycleId",
                table: "Rent",
                column: "MotorcycleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Rent");

            migrationBuilder.DropTable(
                name: "Agency");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Motorcycle");

            migrationBuilder.DropTable(
                name: "Garage");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
