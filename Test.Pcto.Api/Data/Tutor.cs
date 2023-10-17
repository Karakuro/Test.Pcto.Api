using System.Text.Json.Serialization;

namespace Test.Pcto.Api.Data
{
    public class Tutor
    {
        [JsonPropertyName("tutorId")]
        public int TutorId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("students")]
        public List<Student> Students { get; set; }
    }
}
