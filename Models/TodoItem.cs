using System.ComponentModel.DataAnnotations;

namespace DotnetTodos.Models
{
    public class TodoItem
    {
        // Shorthand for property getter/setter
        public long Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public bool IsComplete { get; set; }

    }
}