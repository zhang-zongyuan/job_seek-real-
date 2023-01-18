using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newdb_update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "8e88da12-f1c2-484d-b91d-9213a25cf739");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "bbfbe9c4-f9de-4996-af6c-0769f26f67c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6d3fb47-8e85-4685-85aa-45db1435abc2", "AQAAAAEAACcQAAAAEMKDP71TtN1+WI6mNsLppXXrOHzkMNb2jgkflbmp2bbXtvoXxxf7JOtGKj/qN9ITLw==", "33fd1126-7ea1-47ee-9767-f59b9da32011" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 47, 29, 589, DateTimeKind.Local).AddTicks(9477), new DateTime(2023, 1, 9, 9, 47, 29, 593, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 47, 29, 593, DateTimeKind.Local).AddTicks(8437), new DateTime(2023, 1, 9, 9, 47, 29, 593, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 47, 29, 598, DateTimeKind.Local).AddTicks(970), new DateTime(2023, 1, 9, 9, 47, 29, 598, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 47, 29, 598, DateTimeKind.Local).AddTicks(1046), new DateTime(2023, 1, 9, 9, 47, 29, 598, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 47, 29, 599, DateTimeKind.Local).AddTicks(5966), new DateTime(2023, 1, 9, 9, 47, 29, 599, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 47, 29, 599, DateTimeKind.Local).AddTicks(6000), new DateTime(2023, 1, 9, 9, 47, 29, 599, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 47, 29, 599, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 1, 9, 9, 47, 29, 599, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 47, 29, 599, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 1, 9, 9, 47, 29, 599, DateTimeKind.Local).AddTicks(6020) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "46a88839-1562-48fe-a279-bcf71b8be1a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "949dc2a6-f490-483c-bb2a-17bd5a58fceb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "850eb158-c077-47df-a40e-c53d50b1fe16", "AQAAAAEAACcQAAAAEBayDmtoJb8R9s8Ms4EcINzDG/Dcjj+sOmTCbXK6eMSxkbnr6d+kXVhEbhx8fdK8DQ==", "a5302e3b-2572-4fdc-a185-21f7ad909bc8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 45, 3, 482, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 1, 3, 13, 45, 3, 485, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 45, 3, 486, DateTimeKind.Local).AddTicks(126), new DateTime(2023, 1, 3, 13, 45, 3, 486, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 45, 3, 488, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 1, 3, 13, 45, 3, 488, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 45, 3, 488, DateTimeKind.Local).AddTicks(4863), new DateTime(2023, 1, 3, 13, 45, 3, 488, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 45, 3, 489, DateTimeKind.Local).AddTicks(1186), new DateTime(2023, 1, 3, 13, 45, 3, 489, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 45, 3, 489, DateTimeKind.Local).AddTicks(1208), new DateTime(2023, 1, 3, 13, 45, 3, 489, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 45, 3, 489, DateTimeKind.Local).AddTicks(1217), new DateTime(2023, 1, 3, 13, 45, 3, 489, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 45, 3, 489, DateTimeKind.Local).AddTicks(1226), new DateTime(2023, 1, 3, 13, 45, 3, 489, DateTimeKind.Local).AddTicks(1229) });
        }
    }
}
