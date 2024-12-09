using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAQsApp.Models
{
    public class FAQ
    {
        [Key]
        public int FAQId { get; set; }

        [Required]
        public string Question { get; set; } = string.Empty;

        [Required]
        public string Answer { get; set; } = string.Empty;

        [Required]
        public string TopicId { get; set; } = string.Empty;

        [Required]
        public string CategoryId { get; set; } = string.Empty;

        public Topic Topic { get; set; } = null!;  
        
        public Category Category { get; set; } = null!;  
    }
}
