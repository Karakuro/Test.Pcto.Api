namespace Test.Pcto.Api.Data
{
    public class ClassSection
    {
        public int ClassSectionId { get; set; }
        public string Name { get; set; }
        public int ClassRoomId { get; set; }
        public int SchoolYearId { get; set; }
        public int CourseId { get; set; }
        public List<ClassGroup> ClassGroups { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
