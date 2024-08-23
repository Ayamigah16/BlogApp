using System.Runtime.Intrinsics.X86;

namespace Data.Models;
{
    public class BlogPost
    {   
        // define the properties of the BlogPost class
        public string? Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public Category? Category { get; set; }
        public List<Tag> Tags { get; set; } = new();
    }
}