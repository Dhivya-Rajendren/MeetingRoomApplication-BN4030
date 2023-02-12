using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingRoom.Data.Migrations
{
    public partial class AddingForiegnKeyProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeetingRoom",
                table: "tbl_Meetings");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Meetings_MeetingRoomId",
                table: "tbl_Meetings",
                column: "MeetingRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Meetings_tbl_MeetingRooms_MeetingRoomId",
                table: "tbl_Meetings",
                column: "MeetingRoomId",
                principalTable: "tbl_MeetingRooms",
                principalColumn: "MeetingRoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Meetings_tbl_MeetingRooms_MeetingRoomId",
                table: "tbl_Meetings");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Meetings_MeetingRoomId",
                table: "tbl_Meetings");

            migrationBuilder.AddColumn<string>(
                name: "MeetingRoom",
                table: "tbl_Meetings",
                type: "char(30)",
                nullable: false,
                defaultValue: "");
        }
    }
}
