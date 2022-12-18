using System.ComponentModel.DataAnnotations;

namespace CommandsMemoAPI.Models;

public class Command
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "The How To field is required"), MaxLength(200)]
    public string HowTo { get; set; } = null!;
    [Required(ErrorMessage = "The Platform field is required"), MaxLength(25)]
    public string Platform { get; set; } = null!;
    [Required(ErrorMessage = "The Command Line field is required"), MaxLength(100)]
    public string CommandLine { get; set; } = null!;
}