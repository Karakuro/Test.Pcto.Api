using Microsoft.EntityFrameworkCore;

namespace Test.Pcto.Api.Data
{
    [PrimaryKey(nameof(StudentId), nameof(ClassSectionId))]
    public class ClassGroup
    {
        public int StudentId { get; set; }
        public int ClassSectionId { get; set; }
        public Student Student { get; set; }
        public ClassSection ClassSection { get; set; }
    }
}
