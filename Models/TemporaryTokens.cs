using System.ComponentModel.DataAnnotations;

namespace friendly_broccoli.Models;
public class TemporaryTokens
{
    [Required]
    public required Guid Id { get; set; }
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    public required string Token { get; set; }
    [Required]
    public required string Type { get; set; }
    [Required]
    public required DateTime Created_At { get; set; }
    [Required]
    public required DateTime Expires_At { get; set; }
}