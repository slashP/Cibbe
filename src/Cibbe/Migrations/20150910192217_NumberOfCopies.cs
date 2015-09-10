using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Cibbe.Migrations
{
    public partial class NumberOfCopies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfCopies",
                table: "Book",
                isNullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "NumberOfCopies", table: "Book");
        }
    }
}
