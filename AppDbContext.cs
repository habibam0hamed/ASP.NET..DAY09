namespace TaskManagementSystemm.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TaskManagementSystemm.Domain;

public class AppDbContext : DbContext
{
    public DbSet<TaskItem> Tasks { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskItem>()
            .Property(t => t.Title)
            .HasMaxLength(100);

        modelBuilder.Entity<TaskItem>()
            .Property(t => t.Description)
            .HasMaxLength(500);

        modelBuilder.Entity<TaskItem>()
            .Property(t => t.CreatedAt);
            
}
}
