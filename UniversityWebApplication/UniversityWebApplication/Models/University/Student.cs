using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityWebApplication.Models.University
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
        public string City { get; set; }


        public override string ToString()
        {
            return $"Student(Id:{Id}, Name:{Name}, Score:{Score}, City:{City})";
        }

    }
}
