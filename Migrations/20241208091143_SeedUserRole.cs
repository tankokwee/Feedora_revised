using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Feedora_revised.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(6857), new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(6887), new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "DeliveryPartner",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(7323), new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "DeliveryPartner",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(7326), new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 12, 8, 17, 11, 42, 397, DateTimeKind.Local).AddTicks(7210) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9382), new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9406), new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "DeliveryPartner",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9721), new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "DeliveryPartner",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9723), new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9642), new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9644), new DateTime(2024, 12, 8, 17, 2, 23, 376, DateTimeKind.Local).AddTicks(9644) });
        }
    }
}
