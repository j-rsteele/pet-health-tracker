using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class connectedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "MedicalRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "PetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "PetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "PetId",
                value: 3);

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

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PetId",
                table: "MedicalRecords",
                column: "PetId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Pets_PetId",
                table: "MedicalRecords",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Pets_PetId",
                table: "MedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_PetId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "MedicalRecords");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 5, 32, 994, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(1348));
        }
    }
}
