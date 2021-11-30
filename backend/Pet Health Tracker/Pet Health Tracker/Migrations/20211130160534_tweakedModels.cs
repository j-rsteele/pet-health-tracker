using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class tweakedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clinic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryVet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalRecordId = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    TreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItems_MedicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Weights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentWeight = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weights_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MedicalRecords",
                columns: new[] { "Id", "City", "Clinic", "Phone", "PrimaryVet", "State", "Street", "Zip" },
                values: new object[,]
                {
                    { 1, "Bedford", "Bedford Animal Hospital", "440-555-1298", "Dr. Doolittle", "OH", "412 Oak Ln", "44123" },
                    { 2, "Cleveland", "Gateway Animal Hospital", "216-555-6728", "Dr. Bob", "OH", "Abbey Ave", "44102" },
                    { 3, "Maple Heights", "Suburban Veterinarian Clinic", "330-555-7263", "Dr. Scott", "OH", "58 Maple St", "44242" }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Dan", "Fairchild" },
                    { 2, "Kevin", "Tousey" }
                });

            migrationBuilder.InsertData(
                table: "MedicalItems",
                columns: new[] { "Id", "Description", "ItemType", "MedicalRecordId", "TreatedOn" },
                values: new object[,]
                {
                    { 1, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 0, 1, new DateTime(2021, 11, 30, 11, 5, 32, 994, DateTimeKind.Local).AddTicks(5764) },
                    { 4, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 3, 1, new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8304) },
                    { 3, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 2, 2, new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8296) },
                    { 5, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 4, 2, new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8308) },
                    { 2, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 1, 3, new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8234) },
                    { 6, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 5, 3, new DateTime(2021, 11, 30, 11, 5, 33, 2, DateTimeKind.Local).AddTicks(8312) }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Gender", "Name", "OwnerId", "Photo", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Husky Mix", "Male", "Brewster", 1, "", "Dog" },
                    { 3, 2, "Black Sable", "Male", "Slim Jim", 1, "", "Ferret" },
                    { 2, 6, "Maltese", "Female", "Princess Trudy", 2, "", "Dog" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "ApptDateTime", "Caregiver", "Description", "EmailAddress", "Notes", "PetId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(2847), "Dr Doolittle", "Annual Checkup", "brewster@gmail.com", "Check lump on ribs, bring in stool sample", 1 },
                    { 2, new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(4590), "Pet Smart Grooming", "Hair Trim and Bath, Toenail trim", "princesstrudy@gmail.com", "Full spa treatment", 2 }
                });

            migrationBuilder.InsertData(
                table: "Weights",
                columns: new[] { "Id", "CurrentWeight", "Date", "PetId" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(596), 1 },
                    { 3, 2, new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(1348), 3 },
                    { 2, 12, new DateTime(2021, 11, 30, 11, 5, 33, 3, DateTimeKind.Local).AddTicks(1330), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PetId",
                table: "Appointments",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItems_MedicalRecordId",
                table: "MedicalItems",
                column: "MedicalRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Weights_PetId",
                table: "Weights",
                column: "PetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "MedicalItems");

            migrationBuilder.DropTable(
                name: "Weights");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
