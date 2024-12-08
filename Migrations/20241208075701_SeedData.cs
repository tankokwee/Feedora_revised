using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Feedora_revised.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Password", "PhoneNum", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(891), new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(920), "WayneToh", "P@ssword1", 1, "System" },
                    { 2, "System", new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(923), "Kokwee", "P@ssword1", 2, "System" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryPartner",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Password", "PhoneNum", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(1306), new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(1306), "Reina", "P@ssword1", 5, "System" },
                    { 2, "System", new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(1308), new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(1309), "Oc", "P@ssword1", 6, "System" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Password", "PhoneNum", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(1208), new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(1208), "Mcdonald", "P@ssword1", 3, "System" },
                    { 2, "System", new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(1210), new DateTime(2024, 12, 8, 15, 56, 59, 980, DateTimeKind.Local).AddTicks(1211), "Pizzahut", "P@ssword1", 4, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeliveryPartner",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeliveryPartner",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
