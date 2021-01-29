using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class lastMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2021, 1, 29, 22, 26, 40, 778, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2021, 1, 29, 22, 26, 40, 781, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Birthdate", "Discriminator", "FirstName", "LastName" },
                values: new object[] { 5, new DateTime(2021, 1, 29, 22, 26, 40, 781, DateTimeKind.Local).AddTicks(8857), "Client", "Andrzej", "Łachuda" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Discriminator", "Email", "FirstName", "LastName" },
                values: new object[] { 6, "Doctor", "dr.hous@dr.pl", "Grigory", "Haus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2021, 1, 29, 22, 12, 58, 90, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                column: "Birthdate",
                value: new DateTime(2021, 1, 29, 22, 12, 58, 93, DateTimeKind.Local).AddTicks(6938));
        }
    }
}
