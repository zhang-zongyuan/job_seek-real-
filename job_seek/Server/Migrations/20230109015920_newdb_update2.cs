using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newdb_update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "574c33ff-9402-4f98-a55b-fc5af900f0b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "366fd039-a7f8-43b7-9b62-68026d297664");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc7245d8-b460-416e-b373-10bf798d52aa", "AQAAAAEAACcQAAAAEPoYe2DXudXvp7FPwNv5+ECmg6bAuX1IgpEu6fguIffzHHUIviRMuHM2ALIrxVavxw==", "8c0db07a-5c56-4434-a2d9-514943b02559" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 59, 19, 326, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 1, 9, 9, 59, 19, 327, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 59, 19, 327, DateTimeKind.Local).AddTicks(5954), new DateTime(2023, 1, 9, 9, 59, 19, 327, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(5099), new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(5127), new DateTime(2023, 1, 9, 9, 59, 19, 329, DateTimeKind.Local).AddTicks(5133) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
