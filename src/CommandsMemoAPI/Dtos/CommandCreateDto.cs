using System.ComponentModel.DataAnnotations;

namespace CommandsMemoAPI.Dtos;

public class CommandCreateDto
{
    [Required(ErrorMessage = "The How To field is required"), MaxLength(200)]
    public string HowTo { get; set; } = null!;
    [Required(ErrorMessage = "The Platform field is required"), MaxLength(25)]
    public string Platform { get; set; } = null!;
    [Required(ErrorMessage = "The Command Line field is required"), MaxLength(100)]
    public string CommandLine { get; set; } = null!;
}