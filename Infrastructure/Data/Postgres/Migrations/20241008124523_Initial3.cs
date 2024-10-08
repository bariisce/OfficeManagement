using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 8, 15, 41, 21, 823, DateTimeKind.Utc).AddTicks(8251));
        }
    }
}
