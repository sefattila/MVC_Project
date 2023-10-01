using Microsoft.EntityFrameworkCore;
using MVC_Project.Models.Entities.Classes;

namespace MVC_Project.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Lessons)
                .WithMany(l => l.Students)
                .UsingEntity(x => x.ToTable("StudentLesson"));

            modelBuilder.Entity<Lesson>()
                .HasMany(l => l.Schools)
                .WithMany(s => s.Lessons)
                .UsingEntity(x => x.ToTable("LessonSchool"));
        }
    }
}
