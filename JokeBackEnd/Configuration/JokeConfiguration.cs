using JokeBackEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JokeBackEnd.Configuration
{
	public class JokeConfiguration : IEntityTypeConfiguration<Joke>
	{
		public void Configure(EntityTypeBuilder<Joke> builder)
		{
			builder.ToTable("jokes");
			builder.HasKey(j => j.Id);
			builder.Property(j => j.Contentstory).IsRequired();
		}
	}
}
