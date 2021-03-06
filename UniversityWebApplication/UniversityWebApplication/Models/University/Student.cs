﻿using UniversityWebApplication.Providers.University;

namespace UniversityWebApplication.Models.University
{
    public class Student : IHasId
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public double Score { get; set; }

        public bool IsGettingTuition { get; set; }
    }
}
