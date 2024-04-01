using JokeBackEnd.Data;
using JokeBackEnd.Models;
using JokeBackEnd.Service.Jokes;

namespace JokeBackEnd.Service
{
	public class JokesService : IJokesService
	{
		private readonly JokesDbContext _jokesDbContext;
		public JokesService(JokesDbContext jokesDbContext)
		{
			_jokesDbContext = jokesDbContext;
		}

		public bool AddJoke(Joke joke)
		{
			throw new NotImplementedException();

		}

		public bool DeleteJoke(Joke joke)
		{
			throw new NotImplementedException();
		}

		public List<Joke> GetJokes()
		{
			return _jokesDbContext.Jokes.ToList();
		}

		public bool UpdateJoke(Joke joke)
		{
			throw new NotImplementedException();
		}
	}
}
