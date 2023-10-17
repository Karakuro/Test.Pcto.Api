using Microsoft.EntityFrameworkCore;

namespace Test.Pcto.Api.Data
{
    [PrimaryKey(nameof(StudentId), nameof(SubjectId), nameof(ExamId))]
    public class Degree
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int ExamId { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public Exam Exam { get; set; }
    }
}
