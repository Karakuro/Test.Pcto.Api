namespace Test.Pcto.Api.Data
{
    public class Tutor
    {
        public int TutorId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
