using EAMS.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace EAMS.Application.Contracts
{
    public interface IDatabaseService
    {
        DbSet<User> Users { get; set; }
        DbSet<AttendanceRecord> AttendanceRecords { get; set; }

        int DBSaveChanges();
        Task<int> DBSaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
