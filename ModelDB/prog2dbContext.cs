using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Programming2.ModelDB
{
    public partial class prog2dbContext : DbContext
    {
        public prog2dbContext()
        {
        }

        public prog2dbContext(DbContextOptions<prog2dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cake> Cakes { get; set; } = null!;
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=prog2db;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.19-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Cake>(entity =>
            {
                entity.ToTable("cake");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Stok).HasColumnType("int(11)");

                entity.Property(e => e.Nama).HasMaxLength(50);

                entity.Property(e => e.Harga).HasMaxLength(50);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
