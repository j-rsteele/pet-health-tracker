using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class addedAppointmentsDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Weight",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "RecordType",
                table: "MedicalItem",
                newName: "ItemType");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    ApptDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caregiver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "ApptDateTime", "Caregiver", "Description", "EmailAddress", "Notes", "PetId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 29, 11, 44, 56, 732, DateTimeKind.Local).AddTicks(9891), "Dr Doolittle", "Annual Checkup", "brewster@gmail.com", "Check lump on ribs, bring in stool sample", 1 },
                    { 2, new DateTime(2021, 11, 29, 11, 44, 56, 733, DateTimeKind.Local).AddTicks(1439), "Pet Smart Grooming", "Hair Trim and Bath, Toenail trim", "princesstrudy@gmail.com", "Full spa treatment", 2 },
                    { 3, new DateTime(2021, 11, 29, 11, 44, 56, 733, DateTimeKind.Local).AddTicks(1458), "Exotic Vet Hospital", "Toenail Trim & tooth extraction", "slimjim@gmail.com", "No food after midnight the night before", 3 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PetId",
                table: "Appointments",
                column: "PetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Weight",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "ItemType",
                table: "MedicalItem",
                newName: "RecordType");

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 23, 14, 59, 43, 335, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MedicalRecordId", "TreatedOn" },
                values: new object[] { 2, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MedicalRecordId", "TreatedOn" },
                values: new object[] { 3, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "TreatedOn",
                value: new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MedicalRecordId", "TreatedOn" },
                values: new object[] { 2, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "MedicalItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MedicalRecordId", "TreatedOn" },
                values: new object[] { 3, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Weight",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Weight",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Weight",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(7357));
        }
    }
}
