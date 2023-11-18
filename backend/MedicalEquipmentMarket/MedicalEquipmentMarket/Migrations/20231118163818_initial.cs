using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalEquipmentMarket.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Aparat za osluskivanja rada pluca i srca", "Stetoskop", 20000.0 },
                    { 2, "Namestaj za pacijente", "Krevet", 14000.0 },
                    { 3, "Oprema za previjanje", "Pakovanje zavoja", 1200.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
