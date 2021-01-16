using Microsoft.EntityFrameworkCore.Migrations;

namespace disaster.data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Disasters_DisasterId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Disasters_DisasterId",
                table: "Towns");

            migrationBuilder.AlterColumn<int>(
                name: "DisasterId",
                table: "Towns",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DisasterId",
                table: "Cities",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Disasters_DisasterId",
                table: "Cities",
                column: "DisasterId",
                principalTable: "Disasters",
                principalColumn: "DisasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Disasters_DisasterId",
                table: "Towns",
                column: "DisasterId",
                principalTable: "Disasters",
                principalColumn: "DisasterId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Disasters_DisasterId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Disasters_DisasterId",
                table: "Towns");

            migrationBuilder.AlterColumn<int>(
                name: "DisasterId",
                table: "Towns",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisasterId",
                table: "Cities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Disasters_DisasterId",
                table: "Cities",
                column: "DisasterId",
                principalTable: "Disasters",
                principalColumn: "DisasterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Disasters_DisasterId",
                table: "Towns",
                column: "DisasterId",
                principalTable: "Disasters",
                principalColumn: "DisasterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
