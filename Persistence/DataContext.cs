using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) // pass options to base class
    {
    }

    public DbSet<Activity> Activities { get; set; }// Activities table

}