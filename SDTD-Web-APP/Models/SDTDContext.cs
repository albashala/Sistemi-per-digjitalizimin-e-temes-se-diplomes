using Microsoft.EntityFrameworkCore;

namespace SDTD_Web_APP.Models
{
    public class SDTDContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Thesis> Theses { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=SDTD-DB;Trusted_Connection=True;");
        }
    }
}
