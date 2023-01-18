using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class FirstNameLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "a2780e89-405d-4d3b-9cd1-2d4467162af8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "19be10d8-a9a1-42ce-b766-d17b836f47e2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faebea81-08d3-4cdf-bce6-be59ff7419d0", "AQAAAAEAACcQAAAAEKHYgzAqqCgGsHfXmBT33/+WO7f8rk9k01TtLAxRY/x0ATM9vcDLEFEkmjoW+vLvWg==", "6181260d-8871-4f97-bf96-a5c76f041185" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 37, 55, 553, DateTimeKind.Local).AddTicks(9444), new DateTime(2023, 1, 3, 13, 37, 55, 555, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 37, 55, 555, DateTimeKind.Local).AddTicks(1786), new DateTime(2023, 1, 3, 13, 37, 55, 555, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(3269), new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(3286), new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(6612), new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(6616), new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 1, 3, 13, 37, 55, 556, DateTimeKind.Local).AddTicks(6622) });
        }
    }
}
