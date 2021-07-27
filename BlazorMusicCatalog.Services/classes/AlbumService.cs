using BlazorMusicCatalog.Data;
using BlazorMusicCatalog.Models;
using BlazorMusicCatalog.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMusicCatalog.Services.classes
{
    public class AlbumService : IAlbumService
    {
        private readonly ApplicationDbContext _dbContext;

        public AlbumService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> DeleteAlbum(Album album)
        {
            _dbContext.Remove(album);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<Album> GetAlbumDetails(int id)
        {
            return await _dbContext.Albums
                .Where(s => s.Id == id)
                .Include(s => s.Songs)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Album>> GetAlbums()
        {
            return await _dbContext.Albums.ToListAsync();
        }

        public async Task<bool> InsertAlbum(Album album)
        {
            _dbContext.Add(album);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAlbum(Album album)
        {
            _dbContext.Update(album);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
