
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


public class EMSContext: DbContext
{
    public EMSContext(DbContextOptions<EMSContext> options): base(options)
    {

    }

    public DbSet<Person> People { get; set;}
}