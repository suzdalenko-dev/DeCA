using Microsoft.EntityFrameworkCore;

public class DeCaDbContext : DbContext
{
    public DeCaDbContext(DbContextOptions<DeCaDbContext> options) : base(options){}
    public DbSet<User> Users  { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>(entity => {
            entity.HasKey(u => u.Id);
            entity.HasIndex(u => u.Email).IsUnique();
        });
    }


}