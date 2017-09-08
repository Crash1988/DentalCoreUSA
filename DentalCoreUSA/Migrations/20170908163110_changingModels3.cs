using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DentalCoreUSA.Migrations
{
    public partial class changingModels3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "chairId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Chair",
                columns: table => new
                {
                    chairId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    chairName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    provider = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chair", x => x.chairId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_chairId",
                table: "Appointment",
                column: "chairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Chair_chairId",
                table: "Appointment",
                column: "chairId",
                principalTable: "Chair",
                principalColumn: "chairId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Chair_chairId",
                table: "Appointment");

            migrationBuilder.DropTable(
                name: "Chair");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_chairId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "chairId",
                table: "Appointment");
        }
    }
}
