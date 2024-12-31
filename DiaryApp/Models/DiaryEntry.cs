using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title!")] // Annotating for required value
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Title must be between 3 to 100 characters!")]
        public string Title { get; set; } = string.Empty; // Default value
        public string? Content { get; set; } // Declare a nullable
        [Required(ErrorMessage = "Please select a date!")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
