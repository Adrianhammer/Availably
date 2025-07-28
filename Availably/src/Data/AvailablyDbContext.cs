namespace Availably.Data;
using Api.Entities;
using Microsoft.EntityFrameworkCore;

public class AvailablyDbContext : DbContext
{
    public AvailablyDbContext(DbContextOptions<AvailablyDbContext> options)
        : base(options) { }
    
    public DbSet<Group> Groups { get; set; } //Represents Groups table
}