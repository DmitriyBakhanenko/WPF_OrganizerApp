using System.Collections.Generic;
using Organizer.Model;

namespace Organizer.Data
{
    public interface IPersonDataService
    {
        IEnumerable<Person> GetAll();
    }
}