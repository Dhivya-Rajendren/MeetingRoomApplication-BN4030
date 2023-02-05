using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingRoom.Data.Migrations
{
    public partial class AddingaIsActiveColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "tbl_MeetingRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "tbl_MeetingRooms");
        }
    }
}
