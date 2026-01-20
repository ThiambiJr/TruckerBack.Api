public class AppDbContext : DbContext
{
    public DbSet<Driver> Drivers => Set<Driver>();
    public DbSet<Truck> Trucks => Set<Truck>();
    public DbSet<Breakdown> Breakdowns => Set<Breakdown>();

    public AppDbContext(DbContextOptions options) : base(options) {}
}
