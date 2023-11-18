using EAMS.Application.Contracts;
using EAMS.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace EAMS.Presistance.Context
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DbSet<User> Users { get; set;}
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }


        public DatabaseService()
        {
            
        }

        public DatabaseService(DbContextOptions<DatabaseService> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public int DBSaveChanges()
        {
            return this.SaveChanges();
        }
        
        public async Task<int> DBSaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await this.SaveChangesAsync(acceptAllChangesOnSuccess: true, cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=EAMSystem.db");
                //optionsBuilder.UseSqlServer(
                //    "Server=.;Initial Catalog=EAMSytemDb;Integrated Security=true;TrustServerCertificate=True");
            }
        }
    }
}
