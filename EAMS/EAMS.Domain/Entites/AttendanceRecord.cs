using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EAMS.Domain.Entites
{
    public class AttendanceRecord
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
        public DateTime TodayDate { get; set; } = DateTime.Now;
        public bool ClockedIn { get; set; } = false;
        public DateTime ClockedInAt { get; set; }
        public bool ClockedOut { get; set; } = false;
        public DateTime ClockedOutAt { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}