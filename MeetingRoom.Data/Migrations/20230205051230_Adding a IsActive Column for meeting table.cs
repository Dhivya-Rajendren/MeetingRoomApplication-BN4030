using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingRoom.Data.Migrations
{
    public partial class AddingaIsActiveColumnformeetingtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "tbl_Meetings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "tbl_Meetings");
        }
    }
}
