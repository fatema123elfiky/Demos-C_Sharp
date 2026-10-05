using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo02.Migrations
{
    /// <inheritdoc />
    public partial class @fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCar_Employees_CarId",
                table: "EmployeeCar");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 10, 1, 20, 39, 56, 628, DateTimeKind.Local).AddTicks(8102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 10, 1, 19, 16, 35, 101, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCar_Employees_CarId",
                table: "EmployeeCar",
                column: "CarId",
                principalTable: "Employees",
                principalColumn: "Age",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCar_Employees_CarId",
                table: "EmployeeCar");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2026, 10, 1, 19, 16, 35, 101, DateTimeKind.Local).AddTicks(5425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2026, 10, 1, 20, 39, 56, 628, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCar_Employees_CarId",
                table: "EmployeeCar",
                column: "CarId",
                principalTable: "Employees",
                principalColumn: "Age",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
