using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 50, 46, 902, DateTimeKind.Utc).AddTicks(2559));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 45, 22, 985, DateTimeKind.Utc).AddTicks(6330));
        }
    }
}
