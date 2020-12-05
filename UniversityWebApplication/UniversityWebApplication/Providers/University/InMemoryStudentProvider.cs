using UniversityWebApplication.Models.University;

namespace UniversityWebApplication.Providers.University
{
    public class InMemoryStudentProvider : InMemoryDataProvider<Student>
    {

        public InMemoryStudentProvider() : base()
        {
            Add(new Student() { Id = 0, Name = "Petras", Age = 15, Score = 5.5, IsGettingTuition = true });
            Add(new Student() { Id = 1, Name = "Ona", Age = 17, Score = 7.5, IsGettingTuition = false });
        }
    }
}
