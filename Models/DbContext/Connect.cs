using Microsoft.EntityFrameworkCore;

public class Connect : DbContext
{

    public DbSet<User> users_tbl { get; set; }
    public DbSet<Flight_info> flights_tbl { get; set; }
    public DbSet<Reserve> reserves_tbl { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder db)
    {
        db.UseSqlServer("Data Source =.;Initial Catalog = Flight_Info;Integrated Security=true");
    }



}