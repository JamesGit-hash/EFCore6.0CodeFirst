using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyInspection.Data.Migrations
{
    public partial class NonClusteredPostcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostCode",
                table: "Property",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Property_PostCode",
                table: "Property",
                column: "PostCode")
                .Annotation("SqlServer:Clustered", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Property_PostCode",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Property");
        }
    }
}
