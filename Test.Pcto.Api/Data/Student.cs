namespace Test.Pcto.Api.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public List<Presence> Presences { get; set; }
        public List<Degree> Degrees { get; set; }
    }
}
