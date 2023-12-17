using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MedicalEquipmentMarket.Migrations.AppDb
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentId);
                });

            migrationBuilder.CreateTable(
                name: "PickupSchedule",
                columns: table => new
                {
                    IdS = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScheduleTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickupSchedule", x => x.IdS);
                });

            migrationBuilder.CreateTable(
                name: "SalesReport",
                columns: table => new
                {
                    IdSales = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanId = table.Column<int>(type: "integer", nullable: false),
                    EquipId = table.Column<int>(type: "integer", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReport", x => x.IdSales);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BuyerAccountId = table.Column<int>(type: "integer", nullable: false),
                    ReservationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyEquipments",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    EquipmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyEquipments", x => new { x.CompanyId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_CompanyEquipments_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyEquipments_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "Address", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Beogradska 26", "Beograd", "Beomed", "021731524" },
                    { 2, "Bulevar Mihajla Pupina 25", "Novi Sad", "Health&Care", "021731522" },
                    { 3, "Futoski put 12", "Novi Sad", "Galenika", "021731511" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "EquipmentId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Aparat za osluskivanja rada pluca i srca", "Stetoskop", 20000.0 },
                    { 2, "Namestaj za pacijente", "Krevet", 14000.0 },
                    { 3, "Oprema za previjanje", "Pakovanje zavoja", 1200.0 }
                });

            migrationBuilder.InsertData(
                table: "PickupSchedule",
                columns: new[] { "IdS", "ScheduleTime", "Status" },
                values: new object[] { 1, new DateTime(2023, 12, 17, 22, 15, 9, 483, DateTimeKind.Utc).AddTicks(6321), "zakazan" });

            migrationBuilder.InsertData(
                table: "SalesReport",
                columns: new[] { "IdSales", "CompanId", "EquipId", "ReportDate" },
                values: new object[] { 1, 1, 0, new DateTime(2023, 12, 17, 22, 15, 9, 483, DateTimeKind.Utc).AddTicks(6245) });

            migrationBuilder.InsertData(
                table: "CompanyEquipments",
                columns: new[] { "CompanyId", "EquipmentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "BuyerAccountId", "CompanyId", "ReservationTime" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2023, 12, 17, 22, 15, 9, 483, DateTimeKind.Utc).AddTicks(6291) },
                    { 2, 1, 1, new DateTime(2023, 12, 17, 22, 15, 9, 483, DateTimeKind.Utc).AddTicks(6293) },
                    { 3, 3, 2, new DateTime(2023, 12, 17, 22, 15, 9, 483, DateTimeKind.Utc).AddTicks(6294) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyEquipments_EquipmentId",
                table: "CompanyEquipments",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CompanyId",
                table: "Reservations",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyEquipments");

            migrationBuilder.DropTable(
                name: "PickupSchedule");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "SalesReport");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
