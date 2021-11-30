using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class updatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItem_MedicalRecords_MedicalRecordId",
                table: "MedicalItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Weight_Pets_PetId",
                table: "Weight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weight",
                table: "Weight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalItem",
                table: "MedicalItem");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Weight",
                newName: "Weights");

            migrationBuilder.RenameTable(
                name: "MedicalItem",
                newName: "MedicalItems");

            migrationBuilder.RenameIndex(
                name: "IX_Weight_PetId",
                table: "Weights",
                newName: "IX_Weights_PetId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItem_MedicalRecordId",
                table: "MedicalItems",
                newName: "IX_MedicalItems_MedicalRecordId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "MedicalRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clinic",
                table: "MedicalRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "MedicalRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryVet",
                table: "MedicalRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ST",
                table: "MedicalRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "MedicalRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "MedicalRecords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PetId",
                table: "MedicalItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weights",
                table: "Weights",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalItems",
                table: "MedicalItems",
                column: "Id");

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
                columns: new[] { "MedicalRecordId", "PetId", "TreatedOn" },
                values: new object[] { 3, 3, new DateTime(2021, 11, 29, 15, 6, 48, 944, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MedicalRecordId", "PetId", "TreatedOn" },
                values: new object[] { 2, 2, new DateTime(2021, 11, 29, 15, 6, 48, 944, DateTimeKind.Local).AddTicks(9961) });

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
                columns: new[] { "MedicalRecordId", "PetId", "TreatedOn" },
                values: new object[] { 2, 2, new DateTime(2021, 11, 29, 15, 6, 48, 944, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MedicalRecordId", "PetId", "TreatedOn" },
                values: new object[] { 3, 3, new DateTime(2021, 11, 29, 15, 6, 48, 944, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Clinic", "Phone", "PrimaryVet", "ST", "Street", "Zip" },
                values: new object[] { "Bedford", "Bedford Animal Hospital", "440-555-1298", "Dr. Doolittle", "OH", "412 Oak Ln", "44123" });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Clinic", "Phone", "PrimaryVet", "ST", "Street", "Zip" },
                values: new object[] { "Cleveland", "Gateway Animal Hospital", "216-555-6728", "Dr. Bob", "OH", "Abbey Ave", "44102" });

            migrationBuilder.UpdateData(
                table: "MedicalRecords",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Clinic", "Phone", "PrimaryVet", "ST", "Street", "Zip" },
                values: new object[] { "Maple Heights", "Suburban Veterinarian Clinic", "330-555-7263", "Dr. Scott", "OH", "58 Maple St", "44242" });

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
                name: "IX_MedicalItems_PetId",
                table: "MedicalItems",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItems_MedicalRecords_MedicalRecordId",
                table: "MedicalItems",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItems_Pets_PetId",
                table: "MedicalItems",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weights_Pets_PetId",
                table: "Weights",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItems_MedicalRecords_MedicalRecordId",
                table: "MedicalItems");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalItems_Pets_PetId",
                table: "MedicalItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Weights_Pets_PetId",
                table: "Weights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weights",
                table: "Weights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalItems",
                table: "MedicalItems");

            migrationBuilder.DropIndex(
                name: "IX_MedicalItems_PetId",
                table: "MedicalItems");

            migrationBuilder.DropColumn(
                name: "City",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "Clinic",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "PrimaryVet",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "ST",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "PetId",
                table: "MedicalItems");

            migrationBuilder.RenameTable(
                name: "Weights",
                newName: "Weight");

            migrationBuilder.RenameTable(
                name: "MedicalItems",
                newName: "MedicalItem");

            migrationBuilder.RenameIndex(
                name: "IX_Weights_PetId",
                table: "Weight",
                newName: "IX_Weight_PetId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalItems_MedicalRecordId",
                table: "MedicalItem",
                newName: "IX_MedicalItem_MedicalRecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weight",
                table: "Weight",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalItem",
                table: "MedicalItem",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 29, 11, 44, 56, 732, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 11, 29, 11, 44, 56, 733, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "ApptDateTime", "Caregiver", "Description", "EmailAddress", "Notes", "PetId" },
                values: new object[] { 3, new DateTime(2021, 11, 29, 11, 44, 56, 733, DateTimeKind.Local).AddTicks(1458), "Exotic Vet Hospital", "Toenail Trim & tooth extraction", "slimjim@gmail.com", "No food after midnight the night before", 3 });

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 29, 11, 44, 56, 728, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MedicalRecordId", "TreatedOn" },
                values: new object[] { 1, new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MedicalRecordId", "TreatedOn" },
                values: new object[] { 1, new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MedicalRecordId", "TreatedOn" },
                values: new object[] { 1, new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MedicalRecordId", "TreatedOn" },
                values: new object[] { 1, new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Weight",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 29, 11, 44, 56, 732, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Weight",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 29, 11, 44, 56, 732, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Weight",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 29, 11, 44, 56, 732, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalItem_MedicalRecords_MedicalRecordId",
                table: "MedicalItem",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weight_Pets_PetId",
                table: "Weight",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
