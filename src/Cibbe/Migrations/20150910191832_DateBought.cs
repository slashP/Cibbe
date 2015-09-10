using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Cibbe.Migrations
{
    public partial class DateBought : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateBought",
                table: "Book",
                isNullable: false,
                defaultValue: new DateTime(2015, 1, 1, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DateBought", table: "Book");
        }
    }
}
