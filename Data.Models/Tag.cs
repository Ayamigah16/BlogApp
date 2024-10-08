using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Tag
    {
        // define the properties of the Tag class
        public string? Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}