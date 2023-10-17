namespace Test.Pcto.Api.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public List<ClassSection> ClassSections { get; set; }
    }
}
