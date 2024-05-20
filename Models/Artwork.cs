namespace AiArtGallery.Models;

public class Artwork
{
    public Guid ArtworkId { get; set; }
    public required string Description { get; set; }
    public required string Medium { get; set; }
    public DateTime Year { get; set; }
    public Guid ArtistId { get; set; }
    public Guid ExhibitionId  { get; set; }
    public required byte[] Image { get; set; }
}