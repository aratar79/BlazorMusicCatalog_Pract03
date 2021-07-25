using BlazorMusicCatalog.Data;
using BlazorMusicCatalog.Models;
using BlazorMusicCatalog.Services.Interfaces;
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
        public Task<bool> DeleteAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public Task<Album> GetAlbumDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Album>> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAlbum(Album album)
        {
            _dbContext.Add(album);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public Task<bool> UpdateAlbum(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
