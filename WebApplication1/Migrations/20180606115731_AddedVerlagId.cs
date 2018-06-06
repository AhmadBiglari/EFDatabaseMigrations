using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class AddedVerlagId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Verlag_VerlagId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "VerlagId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Verlag_VerlagId",
                table: "Books",
                column: "VerlagId",
                principalTable: "Verlag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Verlag_VerlagId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "VerlagId",
                table: "Books",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Verlag_VerlagId",
                table: "Books",
                column: "VerlagId",
                principalTable: "Verlag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
