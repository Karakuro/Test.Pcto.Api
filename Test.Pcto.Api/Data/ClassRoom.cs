namespace Test.Pcto.Api.Data
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public string Name { get; set;}
        public List<ClassSection> Sections { get; set; }
    }
}
