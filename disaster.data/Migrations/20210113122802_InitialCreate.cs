using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace disaster.data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disasters",
                columns: table => new
                {
                    DisasterId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SerialNo = table.Column<string>(nullable: true),
                    GlideNo = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    FinishDate = table.Column<DateTime>(nullable: false),
                    DisasterType = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    TownId = table.Column<int>(nullable: false),
                    Latitute = table.Column<float>(nullable: false),
                    Longtitute = table.Column<float>(nullable: false),
                    Why = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AffectedAreas = table.Column<string>(nullable: true),
                    ApproveState = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disasters", x => x.DisasterId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(nullable: true),
                    DisasterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Disasters_DisasterId",
                        column: x => x.DisasterId,
                        principalTable: "Disasters",
                        principalColumn: "DisasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    SourceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SourceName = table.Column<string>(nullable: true),
                    DisasterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.SourceId);
                    table.ForeignKey(
                        name: "FK_Source_Disasters_DisasterId",
                        column: x => x.DisasterId,
                        principalTable: "Disasters",
                        principalColumn: "DisasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    TownId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TownName = table.Column<string>(nullable: true),
                    DisasterId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    Latitute = table.Column<float>(nullable: false),
                    Longtitute = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.TownId);
                    table.ForeignKey(
                        name: "FK_Towns_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Towns_Disasters_DisasterId",
                        column: x => x.DisasterId,
                        principalTable: "Disasters",
                        principalColumn: "DisasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_DisasterId",
                table: "Cities",
                column: "DisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Source_DisasterId",
                table: "Source",
                column: "DisasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_CityId",
                table: "Towns",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_DisasterId",
                table: "Towns",
                column: "DisasterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Disasters");
        }
    }
}
