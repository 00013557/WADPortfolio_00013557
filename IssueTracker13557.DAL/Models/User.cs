using System.ComponentModel.DataAnnotations;

namespace IssueTracker13557.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Username of the user cannot be empty.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email of the user cannot be empty.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Role/Position of the user cannot be empty.")]
        public string Role { get; set; }
    }
}
