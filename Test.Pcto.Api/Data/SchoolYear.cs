namespace Test.Pcto.Api.Data
{
    public class SchoolYear
    {
        public int SchoolYearId { get; set; }
        public DateTime StartOfYear { get; set; }
        public DateTime EndOfYear { get; set; }
        public string Name { get; set; }
        public List<ClassSection> Sections { get; set; }
    }
}
