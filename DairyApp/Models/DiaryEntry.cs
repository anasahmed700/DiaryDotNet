using System.ComponentModel.DataAnnotations;

namespace DairyApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required] // Annotating for required value
        public string Title { get; set; } = string.Empty; // Default value
        public string? Content { get; set; } // Declare a nullable
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
