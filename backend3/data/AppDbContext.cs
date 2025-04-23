using backend3.models;
using Microsoft.EntityFrameworkCore;

namespace backend3.data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}
    
    public DbSet<Person> SimpleCrud { get; set; }
}