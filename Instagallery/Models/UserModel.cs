using System;
using System.ComponentModel.DataAnnotations;

namespace Instagallery.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string PasswordHash { get; set; }

        public string ProfilePictureUrl { get; set; }

        // Verify password method
        public bool VerifyPassword(string password)
        {
            // Password verification logic here (e.g., hashing comparison)
            return true;
        }
    }
}
