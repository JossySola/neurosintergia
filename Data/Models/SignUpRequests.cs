using System.ComponentModel.DataAnnotations;

namespace neurosintergia.Data.Models;

public class SignUpRequests
{
    public required DateTime Created_At { get; set; }
    [Key]
    public required string Id { get; set; }
    public ApplicationUser User { get; set; } = default!;
    public string Status { get; set; } = "pending";
    public string? ReviewedBy { get; set; }
    public string? Comment { get; set; }
    public DateTime? LastReviewed { get; set; }
}