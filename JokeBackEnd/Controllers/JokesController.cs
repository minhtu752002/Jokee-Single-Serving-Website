using JokeBackEnd.Service.Jokes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JokeBackEnd.Controllers
{
	[Route("v1/api/jokes")]
	[ApiController]
	public class JokesController : ControllerBase
	{
		private readonly IJokesService _jokeService;
		public JokesController(IJokesService jokeService)
		{
			_jokeService = jokeService;
		}
		// GET: api/<JokesController>
		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_jokeService.GetJokes());
		}

		// GET api/<JokesController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<JokesController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<JokesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<JokesController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
