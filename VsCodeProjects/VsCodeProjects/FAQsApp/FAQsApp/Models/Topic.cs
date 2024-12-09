using System.ComponentModel.DataAnnotations;

namespace FAQsApp.Models
{
    public class Topic
    {
        [Key]
        public string TopicId { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}

