using Microsoft.EntityFrameworkCore;
using TWTodoList.EntityConfig;
using TWTodoList.Models;

namespace TWTodoList.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<TodoModel> Todos => Set<TodoModel>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=localhost,1433;Database=TWTodoList;User Id=sa;Password=Root@1234;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration<TodoModel>(new TodoEntityConfig());
    }
}