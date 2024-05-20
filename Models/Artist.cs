namespace AiArtGallery.Models;

public class Artist
{
    public Guid ArtistId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string StageName { get; set; }

}