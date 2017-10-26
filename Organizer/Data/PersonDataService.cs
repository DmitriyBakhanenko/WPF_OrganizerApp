using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.Model;

namespace Organizer.Data
{
    public class PersonDataService : IPersonDataService
    {
        public IEnumerable<Person> GetAll()
        {
            // TODO: Load data from a real database
            yield return new Person {FirstName = "Alla",LastName = "Mskovka"};
            yield return new Person {FirstName = "Igor", LastName = "Rud"};
            yield return new Person {FirstName = "Valeriy", LastName = "Jdanov" };
            yield return new Person {FirstName = "Evgen", LastName = "Voskoviy" };
            
        }
    }
}
