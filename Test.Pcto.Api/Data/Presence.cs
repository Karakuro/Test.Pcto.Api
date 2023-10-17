using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Test.Pcto.Api.Data
{
    [PrimaryKey(nameof(StudentId), nameof(LessonId))]
    public class Presence
    {
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public Student Student { get; set; }
        public Lesson Lesson { get; set; }
    }
}
