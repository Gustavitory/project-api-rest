using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Microsoft.AspNetCore.SignalR;

namespace project_rest.Domain.Models;

public enum EPriority
{
    baja, media, alta
}
public class Task
{
    // [Key]
    public Guid Id { get; set; }
    // [ForeignKey("CategoryId")]
    public Guid CategoryId { get; set; }
    // [Required]
    // [MaxLength(150)]
    public string Title { get; set; }
    // [MaxLength(300)]
    public string Description { get; set; }
    // [Required]
    public EPriority Priority { get; set; }

    public DateTime CreatedAt { get; set; }
    public virtual Category Category { get; set; }

    // [NotMapped]
    public string Resume { get; set; }
    public TimeSpan TimeSpent { get; set; }
}