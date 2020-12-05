using UniversityWebApplication.Models.University;

namespace UniversityWebApplication.Providers.University
{
    public class InMemoryCourseProvider : InMemoryDataProvider<Course>
    {
        public InMemoryCourseProvider() : base()
        {
            Add(new Course() { Id = 0, Name = "C#" });
            Add(new Course() { Id = 1, Name = "Architecture" });
        }
    }
}
