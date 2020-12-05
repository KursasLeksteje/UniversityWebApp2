using UniversityWebApplication.Providers.University;

namespace UniversityWebApplication.Models.University
{
    public class Course : IHasId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
