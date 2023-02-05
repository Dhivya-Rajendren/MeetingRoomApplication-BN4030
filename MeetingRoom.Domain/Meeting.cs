using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom.Domain
{
    public class Meeting
    {

        public int MeetingId { get; set; }
        public int MeetingRoomId { get; set; }
        [Column(TypeName = "char(30)")]
        public string MeetingRoom { get; set; }
        [Column(TypeName = "char(100)")]
        public string Description { get; set; }

        public DateTime MeetingDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
