using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Makalem.Models
{
    public partial class MakaleAraBulContext : DbContext
    {
      
        public MakaleAraBulContext()
        {
         
        }
        public MakaleAraBulContext(DbContextOptions<MakaleAraBulContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Makale> Makale { get; set; }
        public virtual DbSet<MakaleKategori> MakaleKategori { get; set; }
        public virtual DbSet<MakaleTag> MakaleTag { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var b =Startup.Configuration["Baglanti"];
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(b);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.ImageUrl).HasMaxLength(50);

                entity.HasOne(d => d.OlusturulanKullanici)
                    .WithMany(p => p.Kategori)
                    .HasForeignKey(d => d.OlusturulanKullaniciId)
                    .HasConstraintName("FK_Kategori_Kullanici");

                entity.HasOne(d => d.UstKategori)
                    .WithMany(p => p.InverseUstKategori)
                    .HasForeignKey(d => d.UstKategoriId)
                    .HasConstraintName("FK_Kategori_Kategori");
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KullaniciAdi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sifre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Soyadi).HasMaxLength(50);
            });

            modelBuilder.Entity<Makale>(entity =>
            {
                entity.Property(e => e.Baslik).HasMaxLength(50);

                entity.Property(e => e.ImageUrl).HasMaxLength(50);

                entity.Property(e => e.MakaleDili).HasMaxLength(50);

                entity.HasOne(d => d.OlusturulanKullanici)
                    .WithMany(p => p.Makale)
                    .HasForeignKey(d => d.OlusturulanKullaniciId)
                    .HasConstraintName("FK_Makale_Kullanici");
            });

            modelBuilder.Entity<MakaleKategori>(entity =>
            {
                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.MakaleKategori)
                    .HasForeignKey(d => d.KategoriId)
                    .HasConstraintName("FK_MakaleKategori_Kategori");

                entity.HasOne(d => d.Makale)
                    .WithMany(p => p.MakaleKategori)
                    .HasForeignKey(d => d.MakaleId)
                    .HasConstraintName("FK_MakaleKategori_Makale");
            });

            modelBuilder.Entity<MakaleTag>(entity =>
            {
                entity.HasOne(d => d.Makale)
                    .WithMany(p => p.MakaleTag)
                    .HasForeignKey(d => d.MakaleId)
                    .HasConstraintName("FK_MakaleTag_Makale");

                entity.HasOne(d => d.MakaleNavigation)
                    .WithMany(p => p.MakaleTag)
                    .HasForeignKey(d => d.MakaleId)
                    .HasConstraintName("FK_MakaleTag_Tag");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.HasOne(d => d.OlusturlanKullanici)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.OlusturlanKullaniciId)
                    .HasConstraintName("FK_Tag_Kullanici");
            });

            modelBuilder.Entity<Yorum>(entity =>
            {
                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Soyadi).HasMaxLength(50);

                entity.Property(e => e.Yorum1).HasColumnName("Yorum");

                entity.HasOne(d => d.Makale)
                    .WithMany(p => p.Yorum)
                    .HasForeignKey(d => d.MakaleId)
                    .HasConstraintName("FK_Yorum_Makale");
            });
        }
    }
}
