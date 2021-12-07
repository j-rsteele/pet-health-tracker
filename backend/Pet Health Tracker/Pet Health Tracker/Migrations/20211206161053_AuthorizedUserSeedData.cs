using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class AuthorizedUserSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthorizedUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 51, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "AuthorizedUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Username",
                value: "username");

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 43, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(8187));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AuthorizedUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Username",
                value: "dfairchild");

            migrationBuilder.InsertData(
                table: "AuthorizedUsers",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 2, "password", "ktousey" });

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
    }
}
