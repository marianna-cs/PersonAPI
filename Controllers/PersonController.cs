using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonAPI.Data;
using PersonAPI.Service;
using System.ComponentModel.DataAnnotations;

namespace PersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private PersonService _personService;
        public PersonController(PersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var persons = _personService.GetPersons();
            return Ok(persons);
        }

        [HttpPost]
        public IActionResult Create(PersonRequest pr)
        {
            Person person = new Person()
            {
                GID = Guid.NewGuid(),
                FirstName = pr.firstName,
                LastName = pr.lastName
            };
            _personService.Create(person);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(int id, PersonRequest pr)
        {
            Person person = _personService.GetById(id);
            person.FirstName = pr.firstName;
            person.LastName = pr.lastName;
            _personService.Update(person);
            return Ok(person);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Person person = _personService.GetById(id);
            _personService.Delete(person);
            return Ok();
        }
          
    }


    public class PersonRequest 
    {
        [Required]
       public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
    }
}
