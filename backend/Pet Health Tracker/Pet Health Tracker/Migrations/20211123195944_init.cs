using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalRecords_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentWeight = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weight_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalRecordId = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<int>(type: "int", nullable: false),
                    TreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalItem_MedicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Dan", "Fairchild" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Kevin", "Tousey" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Gender", "Name", "OwnerId", "Photo", "Species" },
                values: new object[] { 1, 7, "Husky Mix", "Male", "Brewster", 1, "", "Dog" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Gender", "Name", "OwnerId", "Photo", "Species" },
                values: new object[] { 3, 2, "Black Sable", "Male", "Slim Jim", 1, "", "Ferret" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Gender", "Name", "OwnerId", "Photo", "Species" },
                values: new object[] { 2, 6, "Maltese", "Female", "Princess Trudy", 2, "", "Dog" });

            migrationBuilder.InsertData(
                table: "MedicalRecords",
                columns: new[] { "Id", "PetId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 3 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Weight",
                columns: new[] { "Id", "CurrentWeight", "DateTime", "PetId" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(6775), 1 },
                    { 3, 2, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(7357), 3 },
                    { 2, 12, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(7347), 2 }
                });

            migrationBuilder.InsertData(
                table: "MedicalItem",
                columns: new[] { "Id", "Description", "MedicalRecordId", "RecordType", "TreatedOn" },
                values: new object[,]
                {
                    { 1, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 1, 0, new DateTime(2021, 11, 23, 14, 59, 43, 335, DateTimeKind.Local).AddTicks(5256) },
                    { 4, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 1, 3, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(5071) },
                    { 3, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 3, 2, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(5062) },
                    { 6, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 3, 5, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(5080) },
                    { 2, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 2, 1, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(4955) },
                    { 5, "Cras eu malesuada lectus. Suspendisse vel mattis magna.", 2, 4, new DateTime(2021, 11, 23, 14, 59, 43, 339, DateTimeKind.Local).AddTicks(5075) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalItem_MedicalRecordId",
                table: "MedicalItem",
                column: "MedicalRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PetId",
                table: "MedicalRecords",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_OwnerId",
                table: "Pets",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Weight_PetId",
                table: "Weight",
                column: "PetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalItem");

            migrationBuilder.DropTable(
                name: "Weight");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
