using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAbp.Migrations
{
    public partial class UpdatePerson2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Person",
                nullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Course",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Course",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true);
        }
    }
}
