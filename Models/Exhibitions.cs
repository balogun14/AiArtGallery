namespace AiArtGallery.Models;

public class Exhibitions
{
    public Guid ExhibitionId { get; set; }
    public required string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public required string Description { get; set; }
    public required byte[] Image { get; set; }
}