using BackEnd.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BackEnd
{
    public class ExamContext : DbContext
    {
        public ExamContext()
        {

        }

        public ExamContext(DbContextOptions<ExamContext> options) : base(options)
        {

        }

        public DbSet<LaboratoryWorks> LaboratoryWorks { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Visiting> Visiting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=TeacherJournal;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
