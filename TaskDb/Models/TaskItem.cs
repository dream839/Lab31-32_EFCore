using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace TaskDb.Models;

public class TaskItem
{
    public int Id { get; set; }
    public bool IsCompleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;
    [MaxLength(1000)]
    public string Description { get; set; } = string.Empty;
    [MaxLength(20)]
    public string Priority { get; set; } = "Normal";
}