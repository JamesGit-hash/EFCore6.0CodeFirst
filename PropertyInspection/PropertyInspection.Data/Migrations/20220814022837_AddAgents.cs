using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyInspection.Data.Migrations
{
    public partial class AddAgents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "Inspectors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inspectors_AgentId",
                table: "Inspectors",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspectors_Agents_AgentId",
                table: "Inspectors",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspectors_Agents_AgentId",
                table: "Inspectors");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropIndex(
                name: "IX_Inspectors_AgentId",
                table: "Inspectors");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Inspectors");
        }
    }
}
