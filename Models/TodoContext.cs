using Microsoft.EntityFrameworkCore;

namespace DotnetTodos.Models
{
    // A context represents a session with the database, allowing querying and saving data.
    // Sort of like a repository for a set of entity classes?
    public class TodoContext : DbContext
    {

        // Constructor
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        // Property
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}