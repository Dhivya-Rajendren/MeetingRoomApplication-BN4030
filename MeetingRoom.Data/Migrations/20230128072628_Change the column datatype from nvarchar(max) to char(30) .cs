using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingRoom.Data.Migrations
{
    public partial class Changethecolumndatatypefromnvarcharmaxtochar30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeetingRoomName",
                table: "tbl_MeetingRooms",
                type: "char(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeetingRoomName",
                table: "tbl_MeetingRooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(30)");
        }
    }
}
