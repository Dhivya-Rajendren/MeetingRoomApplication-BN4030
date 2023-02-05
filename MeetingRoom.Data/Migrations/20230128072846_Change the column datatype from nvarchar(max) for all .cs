using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingRoom.Data.Migrations
{
    public partial class Changethecolumndatatypefromnvarcharmaxforall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeetingRoom",
                table: "tbl_Meetings",
                type: "char(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "tbl_Meetings",
                type: "char(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MeetingRoomType",
                table: "tbl_MeetingRooms",
                type: "char(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "tbl_MeetingRooms",
                type: "char(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeetingRoom",
                table: "tbl_Meetings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "tbl_Meetings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(100)");

            migrationBuilder.AlterColumn<string>(
                name: "MeetingRoomType",
                table: "tbl_MeetingRooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "tbl_MeetingRooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(50)");
        }
    }
}
