using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolioUdemy.Migrations
{
    public partial class AddEmailAndMessageDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DetaİL",
                table: "Abouts",
                newName: "Detail");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MessageDetail",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MessageDetail",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "Abouts",
                newName: "DetaİL");

            migrationBuilder.AlterColumn<int>(
                name: "Title",
                table: "Experiences",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
