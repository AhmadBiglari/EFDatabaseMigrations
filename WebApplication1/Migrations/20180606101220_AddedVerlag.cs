using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class AddedVerlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VerlagId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Verlag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verlag", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_VerlagId",
                table: "Books",
                column: "VerlagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Verlag_VerlagId",
                table: "Books",
                column: "VerlagId",
                principalTable: "Verlag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Verlag_VerlagId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Verlag");

            migrationBuilder.DropIndex(
                name: "IX_Books_VerlagId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "VerlagId",
                table: "Books");
        }
    }
}
