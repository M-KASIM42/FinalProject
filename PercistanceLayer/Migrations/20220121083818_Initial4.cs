using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PercistanceLayer.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OnCreatedDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 21, 11, 38, 18, 375, DateTimeKind.Local).AddTicks(8064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 21, 11, 35, 20, 203, DateTimeKind.Local).AddTicks(568));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OnCreatedDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 21, 11, 35, 20, 203, DateTimeKind.Local).AddTicks(568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 21, 11, 38, 18, 375, DateTimeKind.Local).AddTicks(8064));
        }
    }
}
