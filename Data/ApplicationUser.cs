using Microsoft.AspNetCore.Identity;

namespace neurosintergia.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public bool IsBlocked { get; set; } = false;
    public string? BlockReason { get; set; }
}