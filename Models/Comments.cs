namespace AiArtGallery.Models;

public class Comments
{
    public Guid CommentId { get; set; }
    public Guid ArtworkId { get; set; }
    public Guid UserId { get; set; }
    public required string CommentText { get; set; }
    public DateTime CreatedDate { get; set; }
}