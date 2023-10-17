namespace Test.Pcto.Api.Data
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string Description { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Degree> Degrees { get; set; }
    }
}
