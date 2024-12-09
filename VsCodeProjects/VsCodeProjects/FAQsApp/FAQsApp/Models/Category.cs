using System.ComponentModel.DataAnnotations;

namespace FAQsApp.Models
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
