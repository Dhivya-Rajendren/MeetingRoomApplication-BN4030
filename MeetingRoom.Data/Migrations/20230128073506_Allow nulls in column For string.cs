using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingRoom.Data.Migrations
{
    public partial class AllownullsincolumnForstring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeetingRoomName",
                table: "tbl_MeetingRooms",
                type: "char(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MeetingRoomName",
                table: "tbl_MeetingRooms",
                type: "char(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(30)",
                oldNullable: true);
        }
    }
}
