using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingRoom.Data.Migrations
{
    public partial class Changeinthetablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Meetings",
                table: "Meetings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeetingRooms",
                table: "MeetingRooms");

            migrationBuilder.RenameTable(
                name: "Meetings",
                newName: "tbl_Meetings");

            migrationBuilder.RenameTable(
                name: "MeetingRooms",
                newName: "tbl_MeetingRooms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Meetings",
                table: "tbl_Meetings",
                column: "MeetingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_MeetingRooms",
                table: "tbl_MeetingRooms",
                column: "MeetingRoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Meetings",
                table: "tbl_Meetings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_MeetingRooms",
                table: "tbl_MeetingRooms");

            migrationBuilder.RenameTable(
                name: "tbl_Meetings",
                newName: "Meetings");

            migrationBuilder.RenameTable(
                name: "tbl_MeetingRooms",
                newName: "MeetingRooms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meetings",
                table: "Meetings",
                column: "MeetingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeetingRooms",
                table: "MeetingRooms",
                column: "MeetingRoomId");
        }
    }
}
