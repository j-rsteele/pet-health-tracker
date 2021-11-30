using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class UpdatedSeedDataAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItems_Pets_PetId",
                table: "MedicalItems");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_PetId",
                table: "MedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItems_PetId",
                table: "MedicalItems");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "MedicalItems");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 501, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 29, 15, 38, 31, 505, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PetId",
                table: "MedicalRecords",
                column: "PetId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_PetId",
                table: "MedicalRecords");

            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "MedicalItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 29, 15, 6, 48, 945, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 29, 15, 6, 48, 945, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PetId", "TreatedOn" },
                values: new object[] { 1, new DateTime(2021, 11, 29, 15, 6, 48, 938, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PetId", "TreatedOn" },
                values: new object[] { 3, new DateTime(2021, 11, 29, 15, 6, 48, 944, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PetId", "TreatedOn" },
                values: new object[] { 2, new DateTime(2021, 11, 29, 15, 6, 48, 944, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PetId", "TreatedOn" },
                values: new object[] { 1, new DateTime(2021, 11, 29, 15, 6, 48, 944, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PetId", "TreatedOn" },
                values: new object[] { 2, new DateTime(2021, 11, 29, 15, 6, 48, 944, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PetId", "TreatedOn" },
                values: new object[] { 3, new DateTime(2021, 11, 29, 15, 6, 48, 944, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 29, 15, 6, 48, 945, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 29, 15, 6, 48, 945, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 29, 15, 6, 48, 945, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PetId",
                table: "MedicalRecords",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItems_PetId",
                table: "MedicalItems",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItems_Pets_PetId",
                table: "MedicalItems",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
