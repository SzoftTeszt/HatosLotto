using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HatosApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jatekos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jatekos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JatekosId = table.Column<int>(type: "int", nullable: false),
                    Sz1 = table.Column<int>(type: "int", nullable: false),
                    Sz2 = table.Column<int>(type: "int", nullable: false),
                    Sz3 = table.Column<int>(type: "int", nullable: false),
                    Sz4 = table.Column<int>(type: "int", nullable: false),
                    Sz5 = table.Column<int>(type: "int", nullable: false),
                    Sz6 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipp_Jatekos_JatekosId",
                        column: x => x.JatekosId,
                        principalTable: "Jatekos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tipp_JatekosId",
                table: "Tipp",
                column: "JatekosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tipp");

            migrationBuilder.DropTable(
                name: "Jatekos");
        }
    }
}
