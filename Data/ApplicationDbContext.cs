using code1st_delete_me.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Code1st.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<City>().HasData(SampleData.GetCities());
        modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
    }

    public DbSet<City>? City { get; set; }
    public DbSet<Province>? Province { get; set; }
}
