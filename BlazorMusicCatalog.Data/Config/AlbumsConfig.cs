using BlazorMusicCatalog.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMusicCatalog.Data.Config
{
    public class AlbumsConfig
    {
        public AlbumsConfig(EntityTypeBuilder<Album> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Title).HasMaxLength(120).IsRequired().IsUnicode();
            entityTypeBuilder.Property(p => p.Description).HasMaxLength(500).IsUnicode();
            entityTypeBuilder.Property(p => p.Author).HasMaxLength(75).IsRequired().IsUnicode();
        }
    }
}
