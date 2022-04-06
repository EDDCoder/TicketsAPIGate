using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SqlDatabaseManager.Models
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<AuthorContact> AuthorContacts { get; set; } = null!;
        public virtual DbSet<Content> Contents { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Geolink> Geolinks { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=33Rjhjds!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("author");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(30)
                    .HasColumnName("nickname");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");

                entity.Property(e => e.Verified).HasColumnName("verified");
            });

            modelBuilder.Entity<AuthorContact>(entity =>
            {
                entity.ToTable("author_contacts");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Number)
                    .HasMaxLength(20)
                    .HasColumnName("number");

                entity.Property(e => e.RealName)
                    .HasMaxLength(30)
                    .HasColumnName("real_name");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("content");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Content1)
                    .HasColumnType("character varying")
                    .HasColumnName("content");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("countries");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Deleted)
                    .HasColumnType("character varying")
                    .HasColumnName("deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            modelBuilder.Entity<Geolink>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("geolink");

                entity.Property(e => e.Createdata).HasColumnName("createdata");

                entity.Property(e => e.Geolink1)
                    .HasMaxLength(300)
                    .HasColumnName("geolink");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("regions");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("tags");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .HasColumnName("name");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.Offerid)
                    .HasName("pk_tickets");

                entity.ToTable("tickets");

                entity.Property(e => e.Offerid).HasColumnName("offerid");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Geolink).HasColumnName("geolink");

                entity.Property(e => e.Region).HasColumnName("region");

                entity.Property(e => e.Tags).HasColumnName("tags");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");

                entity.Property(e => e.Verified).HasColumnName("verified");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
