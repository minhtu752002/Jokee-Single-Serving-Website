using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace JokeBackEnd.Data
{
	public class JokeDbContextFactory : IDesignTimeDbContextFactory<JokesDbContext>
	{
		public JokesDbContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configurationRoot = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connectionString = configurationRoot.GetConnectionString("JokesDatabase");
			var optionBuilder = new DbContextOptionsBuilder<JokesDbContext>();
			optionBuilder.UseSqlServer(connectionString);

			return new JokesDbContext(optionBuilder.Options);
		}
	}
}
