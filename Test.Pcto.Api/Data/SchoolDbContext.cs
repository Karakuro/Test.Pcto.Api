using Microsoft.EntityFrameworkCore;

namespace Test.Pcto.Api.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base() { }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        public DbSet<ClassGroup> ClassGroups { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<ClassSection> ClassSections { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Presence> Presences { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
    }
}
