using API.Entities;
using Microsoft.EntityFrameworkCore;

public class SocialAppContext(DbContextOptions<SocialAppContext> options) : DbContext(options)
{

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, UserName = "John Doe", Email = "doe@mail.com" },
            new User { Id = 2, UserName = "Jane Doe", Email = "jane@mail.com" }
        );

        base.OnModelCreating(modelBuilder);
    }
}