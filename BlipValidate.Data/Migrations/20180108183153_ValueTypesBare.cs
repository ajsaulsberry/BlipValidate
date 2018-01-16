using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BlipValidate.Data.Migrations
{
    public partial class ValueTypesBare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValueTypesBareRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeBoolean = table.Column<bool>(nullable: false),
                    TypeByte = table.Column<byte>(nullable: false),
                    TypeDecimal = table.Column<decimal>(nullable: false),
                    TypeDouble = table.Column<double>(nullable: false),
                    TypeFloat = table.Column<float>(nullable: false),
                    TypeInt = table.Column<int>(nullable: false),
                    TypeLong = table.Column<long>(nullable: false),
                    TypeShort = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueTypesBareRecords", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ValueTypesBareRecords");
        }
    }
}
