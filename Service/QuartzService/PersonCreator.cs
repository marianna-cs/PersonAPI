using PersonAPI.Data;
using Quartz;

namespace PersonAPI.Service.QuartzService
{
    public class PersonCreator : IJob
    {
        private PersonService _personService;
        public PersonCreator(PersonService personService)
        {
            _personService = personService;
        }

        public Task Execute(IJobExecutionContext context)
        {
            var person = new Person();
            person.GID = Guid.NewGuid();
            person.FirstName = "testFN";
            person.LastName = "testLN";
            _personService.AddPerson(person);
            return Task.FromResult(person);
        }
    }
}
