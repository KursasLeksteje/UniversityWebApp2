using System;

namespace UniversityWebApplication.Exeptions
{
    public class ProviderHasNoDataException : Exception
    {
        public ProviderHasNoDataException(int id) : base($"Item with id:{id} is not found in repository.")
        {
        }
    }
}
