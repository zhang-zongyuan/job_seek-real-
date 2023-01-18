using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newdb_update_with_validation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Vehicles_VehicleId",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "97a18f38-411f-463d-87f2-2033d3c3d003");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "189f06d6-6c0a-48e4-8419-b328151f3731");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7070b994-feed-40b2-8967-ff8f060ed98b", "AQAAAAEAACcQAAAAEJ08ofOY/frECbo9WncmfQq9VIt5SQ8hC+wTtl/CHvA7R7s9SHxQ4AeIEJMI3/5uwA==", "d3aebbcf-19c5-4dd8-8130-3e635e0aab49" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 13, 25, 53, DateTimeKind.Local).AddTicks(9607), new DateTime(2023, 1, 9, 10, 13, 25, 55, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 13, 25, 55, DateTimeKind.Local).AddTicks(7669), new DateTime(2023, 1, 9, 10, 13, 25, 55, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(1808), new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(1823), new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(5304), new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(5316), new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(5321), new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(5326), new DateTime(2023, 1, 9, 10, 13, 25, 57, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Vehicles_VehicleId",
                table: "Bookings",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Vehicles_VehicleId",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Bookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "692afbc7-033b-40d2-8aed-8477823c7986");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "7022649d-5c83-4983-9a44-8490cadc246e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "210d22e8-486b-44b8-8d14-7a17f8e379a0", "AQAAAAEAACcQAAAAELk/6Of9r3oO4TxWlou4GlFuUfp8/HnDTjUKzQu6fufdCCsSmUOHBIoXaFQcXEO39Q==", "c0bb9301-c7e0-455b-ac84-2776d2b12a93" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 8, 43, 842, DateTimeKind.Local).AddTicks(9658), new DateTime(2023, 1, 9, 10, 8, 43, 843, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 8, 43, 843, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 1, 9, 10, 8, 43, 843, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 8, 43, 844, DateTimeKind.Local).AddTicks(9402), new DateTime(2023, 1, 9, 10, 8, 43, 844, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 8, 43, 844, DateTimeKind.Local).AddTicks(9415), new DateTime(2023, 1, 9, 10, 8, 43, 844, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 8, 43, 845, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 1, 9, 10, 8, 43, 845, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 8, 43, 845, DateTimeKind.Local).AddTicks(2245), new DateTime(2023, 1, 9, 10, 8, 43, 845, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 8, 43, 845, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 1, 9, 10, 8, 43, 845, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 10, 8, 43, 845, DateTimeKind.Local).AddTicks(2253), new DateTime(2023, 1, 9, 10, 8, 43, 845, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Vehicles_VehicleId",
                table: "Bookings",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
