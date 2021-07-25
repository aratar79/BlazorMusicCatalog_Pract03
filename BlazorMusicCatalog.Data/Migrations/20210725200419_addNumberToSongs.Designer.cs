﻿// <auto-generated />
using System;
using BlazorMusicCatalog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorMusicCatalog.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210725200419_addNumberToSongs")]
    partial class addNumberToSongs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("BlazorMusicCatalog.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(75)
                        .IsUnicode(true)
                        .HasColumnType("varchar(75)");

                    b.Property<byte[]>("CoverImage")
                        .HasColumnType("longblob");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120)
                        .IsUnicode(true)
                        .HasColumnType("varchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("BlazorMusicCatalog.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Extesion")
                        .HasMaxLength(25)
                        .IsUnicode(true)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .IsUnicode(true)
                        .HasColumnType("varchar(120)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("BlazorMusicCatalog.Models.Song", b =>
                {
                    b.HasOne("BlazorMusicCatalog.Models.Album", null)
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId");
                });

            modelBuilder.Entity("BlazorMusicCatalog.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
