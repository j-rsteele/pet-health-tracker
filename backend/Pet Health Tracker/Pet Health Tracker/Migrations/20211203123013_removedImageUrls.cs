using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class removedImageUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 848, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 12, 3, 7, 30, 12, 850, DateTimeKind.Local).AddTicks(3544));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 133, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 133, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 130, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 132, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 132, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 132, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 132, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "TreatedOn",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 132, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 132, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 132, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 12, 3, 7, 24, 43, 132, DateTimeKind.Local).AddTicks(9732));
        }
    }
}
