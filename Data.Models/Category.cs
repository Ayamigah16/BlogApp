using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Category
{
    // define the properties of the Category class
    public String? Id { get; set; }
    
    [Required]
    public String? Name { get; set; } = string.Empty;
    
}