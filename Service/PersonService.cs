using PersonAPI.Data;
using PersonAPI.Repo;
using Microsoft.EntityFrameworkCore;

namespace PersonAPI.Service
{
    public class PersonService
    {
        private BaseContext _baseContext;

        public PersonService(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public void AddPerson(Person person)
        {
            _baseContext.Persons.Add(new Person() {
                GID = Guid.NewGuid()            
            });
        }
        public IEnumerable<Person> GetPersons()
        {
            return _baseContext.Persons.ToList();
        }

        public void Create(Person person)
        {
            _baseContext.Add(person);
            _baseContext.SaveChanges();
        }

        public Person GetById(int id)
        {
            var person = _baseContext.Persons.FirstOrDefault(p => p.Id == id);
            return person;
        }

        public void Update(Person person)
        {
            _baseContext.Entry(person).State = EntityState.Modified;
            _baseContext.SaveChanges();
        }

        public void Delete(Person person)
        {
            _baseContext.Remove(person);
            _baseContext.SaveChanges();
        }
    }
}
