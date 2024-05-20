using AiArtGallery.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace AiArtGallery.DAL;

public class AppDbcontext :IdentityDbContext<User>
{
    public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options)
    {
    }
    public DbSet<Artwork> Artworks { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Exhibitions> Exhibitions { get; set; }
    public DbSet<Comments> Comments { get; set; }
    
}