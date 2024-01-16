using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace project_rest.Domain.Models;

public class Category
{
    // [Key]
    public Guid Id { get; set; }
    // [Required]
    // [MaxLength(150)]
    public string Name { get; set; }
    // [MaxLength(300)]
    public string Description { get; set; }
    public virtual ICollection<Task> Tasks { get; set; }
    public int Peso { get; set; }
}