using JokeBackEnd.Configuration;
using JokeBackEnd.Models;
using JokeBackEnd.Seeders;
using Microsoft.EntityFrameworkCore;

namespace JokeBackEnd.Data
{
	public class JokesDbContext : DbContext
	{
		public JokesDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new JokeConfiguration());

			modelBuilder.Seed();
		}
		public DbSet<Joke> Jokes { get; set; }	
	}
}
