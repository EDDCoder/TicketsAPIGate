using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SqlDatabaseManager.Models.SettingsDb
{
    public partial class settingsdbContext : DbContext
    {
        public settingsdbContext()
        {
        }

        public settingsdbContext(DbContextOptions<settingsdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SearchEngineSetting> SearchEngineSettings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=settingsdb;Username=postgres;Password=33Rjhjds!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SearchEngineSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("search_engine_settings");

                entity.Property(e => e.Key)
                    .HasMaxLength(30)
                    .HasColumnName("key");

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .HasColumnName("value");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
