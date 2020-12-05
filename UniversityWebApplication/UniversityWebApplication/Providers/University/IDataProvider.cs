using System.Collections.Generic;

namespace UniversityWebApplication.Providers.University
{
    public interface IDataProvider<DataClass> 
    {
        //Create
        void Add(DataClass student);
        
        //Read
        List<DataClass> GetAll();
        DataClass Get(int id);

        //Update
        void Update(DataClass student);

        //Delete
        void Remove(int id);
    }
}
