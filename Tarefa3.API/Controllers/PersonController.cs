using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;
using Tarefa3.Domain.Interfaces.Service;
using Tarefa3.Application.Services;

namespace Tarefa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var people = _personService.GetAll();
            return Ok(people);
        }
    }
}
