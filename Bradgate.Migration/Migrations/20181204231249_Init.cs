using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bradgate.Migration.Migrations
{
    [SuppressMessage("ReSharper", "RedundantArgumentDefaultValue")]
    public partial class Init : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeventyPercentClubEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Player1 = table.Column<string>(nullable: true),
                    IsPlayer1Visitor = table.Column<bool>(nullable: false),
                    Player2 = table.Column<string>(nullable: true),
                    IsPlayer2Visitor = table.Column<bool>(nullable: false),
                    Score = table.Column<decimal>(nullable: false),
                    SessionDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeventyPercentClubEntries", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeventyPercentClubEntries");
        }
    }
}
