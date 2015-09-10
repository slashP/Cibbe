using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Cibbe.Migrations
{
    public partial class YearOfBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Book",
                isNullable: false,
                defaultValue: 2000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Year", table: "Book");
        }
    }
}
