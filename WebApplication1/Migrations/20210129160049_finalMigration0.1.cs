using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class finalMigration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "pfisier", "covid-19-vac", "vac" },
                    { 2, "modena", "covid-21-vac", "antivac" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Birthdate", "Discriminator", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 29, 17, 0, 48, 425, DateTimeKind.Local).AddTicks(4799), "Client", "Joe", "Doe" },
                    { 2, new DateTime(2021, 1, 29, 17, 0, 48, 429, DateTimeKind.Local).AddTicks(648), "Client", "Andrzej", "Chuda" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Discriminator", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 3, "Doctor", "doEtkter@dr.pl", "Doktor", "Etker" },
                    { 4, "Doctor", "dtor@dr.pl", "Dok", "Tor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
