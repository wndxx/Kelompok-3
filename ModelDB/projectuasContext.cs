using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UASPemrograman2.ModelDB
{
    public partial class projectuasContext : DbContext
    {
        public projectuasContext()
        {
        }

        public projectuasContext(DbContextOptions<projectuasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Film> Films { get; set; } = null!;
        public virtual DbSet<Pembeli> Pembelis { get; set; } = null!;
        public virtual DbSet<Tiket> Tikets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=projectuas;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.17-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.IdFilm)
                    .HasName("PRIMARY");

                entity.ToTable("film");

                entity.Property(e => e.IdFilm).HasColumnType("int(5)");

                entity.Property(e => e.Harga).HasColumnType("int(7)");

                entity.Property(e => e.Jam).HasMaxLength(15);

                entity.Property(e => e.NamaFilm).HasMaxLength(50);

                entity.Property(e => e.Rating)
                    .HasColumnType("int(5)")
                    .HasColumnName("rating");
            });

            modelBuilder.Entity<Pembeli>(entity =>
            {
                entity.HasKey(e => e.IdPembeli)
                    .HasName("PRIMARY");

                entity.ToTable("pembeli");

                entity.Property(e => e.IdPembeli).HasColumnType("int(11)");

                entity.Property(e => e.NamaPembeli).HasMaxLength(100);

                entity.Property(e => e.Umur)
                    .HasColumnType("int(10)")
                    .HasColumnName("umur");
            });

            modelBuilder.Entity<Tiket>(entity =>
            {
                entity.HasKey(e => e.IdTiket)
                    .HasName("PRIMARY");

                entity.ToTable("tiket");

                entity.Property(e => e.IdTiket).HasColumnType("int(5)");

                entity.Property(e => e.IdFilm).HasColumnType("int(5)");

                entity.Property(e => e.IdPembeli).HasColumnType("int(5)");

                entity.Property(e => e.Tanggal)
                    .HasMaxLength(50)
                    .HasColumnName("tanggal");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
