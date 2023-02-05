using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingRoom.Domain
{
    public class MeetingRoom
    {
        [Key] // is a data annotation which will create a primary key.
        public int MeetingRoomId { get; set; }

        [Column(TypeName ="char(30)")]
        
        public string? MeetingRoomName { get; set; }
        public int? Capacity { get; set; }
        [Column(TypeName = "char(30)")]
        public string MeetingRoomType { get; set; }
  [MaxLength(200)]
        public string Location { get; set; }

        public bool IsActive { get; set; }
    }
}