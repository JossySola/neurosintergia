using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace neurosintergia.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required(ErrorMessage = "El rol es requerido")]
    public required string Role { get; set; }
    public bool IsMFAEnabled { get; set; } = false;
    public bool IsBlocked { get; set; } = false;
    public DateTime LastFailedAttempt { get; set; }
}