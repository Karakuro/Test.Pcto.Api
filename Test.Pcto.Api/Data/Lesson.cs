namespace Test.Pcto.Api.Data
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public int ClassSectionId { get; set; }
        public int? ExamId { get; set; }
        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
        public Exam? Exam { get; set; }
        public ClassSection Section { get; set; }
        public List<Presence> Presences { get; set; }

    }
}
