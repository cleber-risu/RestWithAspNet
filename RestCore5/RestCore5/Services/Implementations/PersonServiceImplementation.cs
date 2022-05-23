using System.Collections.Generic;
using System.Linq;
using RestCore5.Model;
using RestCore5.Model.Context;

namespace RestCore5.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySQLContext _context;

        public PersonServiceImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Alfonso",
                LastName = "Cabral Lacoste",
                Address = "Uberlandia - Minas Gerais - Brasil",
                Gender = "Male",
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}