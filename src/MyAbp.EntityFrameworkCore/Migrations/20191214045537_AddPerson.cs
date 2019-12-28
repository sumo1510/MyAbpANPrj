using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAbp.Migrations
{
    public partial class AddPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    DepartmentCode = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    Credits = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(maxLength: 200, nullable: true),
                    Status = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    CreateName = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdateName = table.Column<string>(maxLength: 50, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
