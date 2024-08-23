namespace Data.Models
{
    public class Comment
    {
        // define the properties of the Comment class
        public string? Id { get; set; }

        // foreign key from BlogPost
        public required string BlogPostId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; } = string.Empty;
        public string Post { get; set; } = string.Empty;
    }
}