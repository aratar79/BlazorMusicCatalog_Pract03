using BlazorMusicCatalog.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMusicCatalog.Data.Config
{
    public class SongsConfig
    {
        public SongsConfig(EntityTypeBuilder<Song> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name).HasMaxLength(120).IsRequired().IsUnicode();
            entityTypeBuilder.Property(p => p.Path).HasMaxLength(500).IsUnicode();
            entityTypeBuilder.Property(p => p.Extesion).HasMaxLength(25).IsUnicode();
        }
    }
}
