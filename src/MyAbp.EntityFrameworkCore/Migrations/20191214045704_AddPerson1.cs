using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAbp.Migrations
{
    public partial class AddPerson1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CreateName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Credits",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "DepartmentCode",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "UpdateName",
                table: "Person");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Person",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateName",
                table: "Person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Credits",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentCode",
                table: "Person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Person",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Person",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateName",
                table: "Person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
