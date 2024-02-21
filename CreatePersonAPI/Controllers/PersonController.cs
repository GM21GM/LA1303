using CreatePersonAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;

namespace CreatePersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonDb _context;
        private Random _random = new Random();
        private string _pathToLastname = @"Data/Lastnames.json";
        private string _pathToFirstname = @"Data/Firstnames.json";
        private string _pathToProfession = @"Data/Professions.json";
            public PersonController(PersonDb context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPerson()
        {
            if (_context.Person == null)
            {
                return NotFound();
            }
            return await _context.Person.ToListAsync();

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            if (_context.Person == null)
            {
                return NotFound();
            }
            var person = await _context.Person.FindAsync(id);
            

            if (person == null)
            {
                return NotFound();
            }
            return Ok(person.Firstname);

        }
        [HttpGet("NewPerson")]
        public async Task<ActionResult> GetNewPerson()
        {
            var person = new Person
            {
                Firstname = GetRndFirstname(_pathToFirstname),
                Lastname = GetRndLastname(_pathToLastname),
                Geburtsdatum = GetRndBirthdate(),
            };
            { 
                var cutoffDate = new DateOnly(2008, 1, 1);

            if (person.Geburtsdatum > cutoffDate)
            {
                person.Beruf = "Student";
            }
            else
            {
                person.Beruf = GetRndProfession(_pathToProfession);
            }


        };
            _context.Person.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerson", person);
        }


        private string GetRndFirstname(string pathToFirstname)
        {
            int x = _random.Next(0, 4900);
            string jsonString = System.IO.File.ReadAllText(pathToFirstname);
            dynamic obj = JsonConvert.DeserializeObject(jsonString);
            return obj[x];
        }

        private string GetRndLastname(string pathToLastname)
        {
            int x = _random.Next(0, 330);
            string jsonString = System.IO.File.ReadAllText(pathToLastname);
            dynamic obj = JsonConvert.DeserializeObject(jsonString);
            return obj[x];
        }

        private string GetRndProfession(string pathToProfessions)
        {
            int x = _random.Next(0, 88);
            string jsonString = System.IO.File.ReadAllText(pathToProfessions);
            dynamic obj = JsonConvert.DeserializeObject(jsonString);
            return obj[x];
        }

        private DateOnly GetRndBirthdate()
        {
            Random rand = new Random();
            int currentYear = DateTime.Now.Year;
            int year = rand.Next(currentYear - 100, currentYear);
            int month = rand.Next(1, 13);
            int day = DateTime.DaysInMonth(year, month);
            int randomDay = rand.Next(1, day + 1);

            DateOnly randomDate = new DateOnly(year, month, randomDay);

            return randomDate;
        }
    }


}