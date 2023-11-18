using System.ComponentModel.DataAnnotations;

namespace EAMS.Domain.Entites
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = new Guid();
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public bool _isAdmin = false;
        public List<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
    }
}
