using Microsoft.EntityFrameworkCore;

public class DeCaDbContext : DbContext
{
    public DeCaDbContext(DbContextOptions<DeCaDbContext> options) : base(options){}
    public DbSet<User> dbUser { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>(entity => {
            entity.HasKey(u => u.Id);
            entity.HasIndex(u => u.Email).IsUnique();
            entity.Property(u => u.Email).HasMaxLength(255).IsRequired();
        });
    }


}