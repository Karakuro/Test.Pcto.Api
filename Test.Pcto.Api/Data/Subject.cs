namespace Test.Pcto.Api.Data
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public List<Degree> Degrees { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
