using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DentalCoreUSA.Migrations
{
    public partial class changingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_VisitType_visitTypefieldOptionId",
                table: "Appointment");

            migrationBuilder.DropTable(
                name: "FieldOption");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_visitTypefieldOptionId",
                table: "Appointment");

            migrationBuilder.AddColumn<bool>(
                name: "active",
                table: "VisitType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "VisitType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "VisitType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "active",
                table: "VisitStatus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "VisitStatus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "VisitStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "visitTypeId",
                table: "Appointment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_visitTypeId",
                table: "Appointment",
                column: "visitTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_VisitType_visitTypeId",
                table: "Appointment",
                column: "visitTypeId",
                principalTable: "VisitType",
                principalColumn: "visitTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_VisitType_visitTypeId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_visitTypeId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "active",
                table: "VisitType");

            migrationBuilder.DropColumn(
                name: "name",
                table: "VisitType");

            migrationBuilder.DropColumn(
                name: "order",
                table: "VisitType");

            migrationBuilder.DropColumn(
                name: "active",
                table: "VisitStatus");

            migrationBuilder.DropColumn(
                name: "name",
                table: "VisitStatus");

            migrationBuilder.DropColumn(
                name: "order",
                table: "VisitStatus");

            migrationBuilder.DropColumn(
                name: "visitTypeId",
                table: "Appointment");

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    fieldId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    fieldDefaultOptionId = table.Column<int>(nullable: false),
                    fieldName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.fieldId);
                });

            migrationBuilder.CreateTable(
                name: "FieldOption",
                columns: table => new
                {
                    fieldOptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    active = table.Column<bool>(nullable: false),
                    fieldId = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldOption", x => x.fieldOptionId);
                    table.ForeignKey(
                        name: "FK_FieldOption_Field_fieldId",
                        column: x => x.fieldId,
                        principalTable: "Field",
                        principalColumn: "fieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_visitTypefieldOptionId",
                table: "Appointment",
                column: "visitTypefieldOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_FieldOption_fieldId",
                table: "FieldOption",
                column: "fieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_VisitType_visitTypefieldOptionId",
                table: "Appointment",
                column: "visitTypefieldOptionId",
                principalTable: "VisitType",
                principalColumn: "visitTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
