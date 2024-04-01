using JokeBackEnd.Models;

namespace JokeBackEnd.Service.Jokes
{
	public interface IJokesService
	{
		List<Joke> GetJokes();
		Boolean AddJoke(Joke joke);
		Boolean UpdateJoke(Joke joke);
		Boolean DeleteJoke(Joke joke);

	}
}
