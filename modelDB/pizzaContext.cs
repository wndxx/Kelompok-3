using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Programming2_UAS.modelDB
{
    public partial class pizzaContext : DbContext
    {
        public pizzaContext()
        {
        }

        public pizzaContext(DbContextOptions<pizzaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pizza> Pizzas { get; set; } = null!;
        public virtual DbSet<Transaksi> Transaksis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=pizza;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.21-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.ToTable("pizza");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Crust)
                    .HasMaxLength(200)
                    .HasColumnName("crust");

                entity.Property(e => e.JenisSaus)
                    .HasMaxLength(200)
                    .HasColumnName("jenis_saus");

                entity.Property(e => e.NamaPizza)
                    .HasMaxLength(200)
                    .HasColumnName("nama_pizza");

                entity.Property(e => e.UkuranPizza)
                    .HasColumnType("int(11)")
                    .HasColumnName("ukuran_pizza");
            });

            modelBuilder.Entity<Transaksi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("transaksi");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.NamaPizza)
                    .HasMaxLength(200)
                    .HasColumnName("nama_pizza");

                entity.Property(e => e.Pcs)
                    .HasMaxLength(100)
                    .HasColumnName("pcs");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
