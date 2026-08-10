using Microsoft.EntityFrameworkCore;
using TheatreAdmin.Models;

namespace TheatreAdmin.Data;

public class TheatreAdminContext(DbContextOptions<TheatreAdminContext> options)
    : DbContext(options)
{
    public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasIndex(category => category.Code)
            .IsUnique();

        modelBuilder.Entity<Movie>()
            .HasOne(movie => movie.Category)
            .WithMany(category => category.Movies)
            .HasForeignKey(movie => movie.CategoryId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}

