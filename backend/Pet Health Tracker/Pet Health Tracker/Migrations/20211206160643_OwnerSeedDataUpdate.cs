using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class OwnerSeedDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "AuthorizedUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizedUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 87, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 87, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.InsertData(
                table: "AuthorizedUsers",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "password", "dfairchild" },
                    { 2, "password", "ktousey" }
                });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 81, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 86, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 86, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 86, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 86, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 86, DateTimeKind.Local).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "First", "Last" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "OwnerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 86, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 86, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 12, 6, 11, 6, 42, 86, DateTimeKind.Local).AddTicks(8864));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorizedUsers");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 480, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dan", "Fairchild" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Kevin", "Tousey" });

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 30, 11, 15, 1, 484, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "OwnerId",
                value: 2);
        }
    }
}
