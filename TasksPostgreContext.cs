using System;
using Microsoft.EntityFrameworkCore;
using projectef.Models;

public class PostgreContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<projectef.Models.Task> Tasks { get; set; }

    public PostgreContext(DbContextOptions<PostgreContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Category> categoryInit = new List<Category>();
        categoryInit.Add(new Category() { Id = Guid.Parse("39cb3662-4846-4072-b47a-f7373b199a9f"), Description = "No description", Name = "Actividades pendientes", Peso = 10 });
        categoryInit.Add(new Category() { Id = Guid.Parse("39cb3662-4846-4072-b47a-f7373b199a02"), Description = "No description", Name = "Actividades personales", Peso = 15 });
        modelBuilder.Entity<Category>(category =>
        {
            category.ToTable("Category");
            category.HasKey(p => p.Id);
            category.Property(p => p.Name).IsRequired().HasMaxLength(150);
            category.Property(p => p.Description).HasMaxLength(500);
            category.Property(p => p.Peso);

            category.HasData(categoryInit);
        });
        modelBuilder.Entity<projectef.Models.Task>(task =>
        {
            task.ToTable("Task");
            task.HasKey(p => p.Id);
            task.Property(p => p.Title).IsRequired().HasMaxLength(150);
            task.Property(p => p.Priority).HasDefaultValue(EPriority.baja);
            task.Property(p => p.CreatedAt);
            task.Property(p => p.Description).HasMaxLength(500);
            task.HasOne(p => p.Category).WithMany(p => p.Tasks).HasForeignKey(p => p.CategoryId);
            task.Ignore(p => p.Resume);
        });
    }
}