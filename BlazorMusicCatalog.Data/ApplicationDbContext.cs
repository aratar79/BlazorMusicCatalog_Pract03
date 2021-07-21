using BlazorMusicCatalog.Data.Config;
using BlazorMusicCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorMusicCatalog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new AlbumsConfig(builder.Entity<Album>());
            new SongsConfig(builder.Entity<Song>());

        }

    }
}
