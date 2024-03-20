using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IssueTracker13557.Models
{
    public class Issue
    {
        //StudentID: 00013557
        public int Id { get; set; }
        [Required(ErrorMessage = "Title of the issue cannot be empty.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description of the issue cannot be empty.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Priority of the issue cannot be empty.")]
        public string Priority { get; set; }
        [Required(ErrorMessage = "Status of the issue cannot be empty.")]
        public string Status { get; set; }
        [Required(ErrorMessage = "UserID of the issue cannot be empty!")]
        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
