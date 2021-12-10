using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Health_Tracker.Migrations
{
    public partial class UpdatedSeedDataMedItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApptDateTime",
                value: new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Rabies", new DateTime(2021, 12, 10, 11, 5, 50, 123, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Removed tumor in foot", new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Flea and tic", new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Male neuter", new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Tests found allergies to: Chicken, Pork, Egg, Turkey, Grains, Peas", new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Hydrocortisone", new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Breed", "Species" },
                values: new object[] { "Black Lab", "Dog" });

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Weights",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(1312));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Cras eu malesuada lectus. Suspendisse vel mattis magna.", new DateTime(2021, 12, 6, 11, 10, 52, 43, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Cras eu malesuada lectus. Suspendisse vel mattis magna.", new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Cras eu malesuada lectus. Suspendisse vel mattis magna.", new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Cras eu malesuada lectus. Suspendisse vel mattis magna.", new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Cras eu malesuada lectus. Suspendisse vel mattis magna.", new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "MedicalItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "TreatedOn" },
                values: new object[] { "Cras eu malesuada lectus. Suspendisse vel mattis magna.", new DateTime(2021, 12, 6, 11, 10, 52, 50, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Breed", "Species" },
                values: new object[] { "Black Sable", "Ferret" });

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
    }
}
