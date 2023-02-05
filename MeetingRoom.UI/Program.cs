using MeetingRoom.Data;
using MeetingRoom.Domain;


Console.WriteLine("Select the option for the Tables");

int tableChoice = int.Parse(Console.ReadLine());

Console.WriteLine("We are Connecting with Database created using the EF Core Code _first approach");
int operationChoice = 0;
string s;
MeetingRoomDbContext dbContext = new MeetingRoomDbContext();
int rowsAffected = 0;

if (tableChoice == 1)
{
    Console.WriteLine("Select 1 -->Adding New Data 2-->Reading  3-->Updating 4-->Delete");
    operationChoice = int.Parse(Console.ReadLine());//C R U D

    switch (operationChoice)
    {


        case 1:
            Console.WriteLine("Enter the detail of Meeting Room");
            MeetingRoom.Domain.MeetingRoom meetingRoom = new MeetingRoom.Domain.MeetingRoom();
            Console.WriteLine("Meeting Room Name :");
            meetingRoom.MeetingRoomName = Console.ReadLine();
            Console.WriteLine("Meeting Room Type");
            meetingRoom.MeetingRoomType = Console.ReadLine();
            Console.WriteLine("Location");
            meetingRoom.Location = Console.ReadLine();
            Console.WriteLine("Capacity of Room");
            meetingRoom.Capacity = int.Parse(Console.ReadLine());


            dbContext.tbl_MeetingRooms.Add(meetingRoom);// Writing a SQL query in editor
            rowsAffected = dbContext.SaveChanges();//The Sql query gets executed .
            if (rowsAffected > 0)
            {
                Console.WriteLine("Meeting Rooms Added");
            }
            break;

        case 2:

          s = String.Format("{0}{1,-90}", "Name                   ", "Room Type");
            Console.WriteLine(s);

            foreach (var item in GetAllMeetingRooms())
            {
                s = String.Format("{0}{1,-30}", item.MeetingRoomName, item.MeetingRoomType);
                Console.WriteLine(s);
            }
            break;
        case 3:
            Console.WriteLine("Enter the RoomName For Update");
            string roomName = Console.ReadLine();
            Console.WriteLine("Enter the New Room Type For Update");
            string roomType = Console.ReadLine();
            MeetingRoom.Domain.MeetingRoom room = dbContext.tbl_MeetingRooms.SingleOrDefault(r => r.MeetingRoomName.Equals(roomName));
            room.MeetingRoomType = roomType;
            rowsAffected = dbContext.SaveChanges();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Room Details Updated");
            }
            break;

        case 4:
            Console.WriteLine("Enter the RoomName For Update");
            string rName = Console.ReadLine();
             MeetingRoom.Domain.MeetingRoom _room = dbContext.tbl_MeetingRooms.SingleOrDefault(r => r.MeetingRoomName.Equals(rName));
            //    dbContext.tbl_MeetingRooms.Remove(_room);
            _room.IsActive = false;
            rowsAffected = dbContext.SaveChanges();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Room Detail Deleted ");
            }


            break;
    }




}

else if(tableChoice==2)
{
    Console.WriteLine("Select 1 -->Adding New Data 2-->Reading  3-->Updating 4-->Delete");
    operationChoice = int.Parse(Console.ReadLine());
    switch(operationChoice)
    {
        case 1:
            break;
        case 2:

            s = String.Format("{0}{1,-90}", "Meeting Name                   ", "Meeting Room");
            Console.WriteLine(s);

            foreach (var item in GetAllMeetings())
            {
                s = String.Format("{0}{1,-60}", item.Description.Trim(), item.MeetingRoom);
                Console.WriteLine(s);
            }



            break;
    }
}

//Console.WriteLine("Enter the detail of Meetings");
//Meeting meeting = new Meeting();
//Console.WriteLine("Meeting Room Name :");
//meeting.MeetingRoom = Console.ReadLine();
//Console.WriteLine("Meeting Description");
//meeting.Description = Console.ReadLine();
//Console.WriteLine("Date & Time of the Meeting");
//meeting.MeetingDateTime =DateTime.Parse( Console.ReadLine());

//meeting.MeetingRoomId = GetAllMeetingRooms().Find(m => m.MeetingRoomName .Trim()== meeting.MeetingRoom).MeetingRoomId;


//      dbContext.tbl_Meetings.Add(meeting);// Writing a SQL query in editor
//dbContext.SaveChanges();//The Sql query gets executed .

// s = String.Format("{0}{1,-90}", "Meeting Name                   ", "Meeting Room");
//Console.WriteLine(s);

//foreach (var item in GetAllMeetings())
//{
//    s = String.Format("{0}{1,-60}", item.Description, item.MeetingRoom);
//    Console.WriteLine(s);
//}




List<Meeting> GetAllMeetings()
{
    return dbContext.tbl_Meetings.ToList();
}
List<MeetingRoom.Domain.MeetingRoom> GetAllMeetingRooms()
{
    List<MeetingRoom.Domain.MeetingRoom> meetingRooms = dbContext.tbl_MeetingRooms.ToList(); // All the records

  //  meetingRooms = dbContext.tbl_MeetingRooms.Where(mr => mr.IsActive).ToList();// FEtch all active data

    return meetingRooms;

}

