using System;
using Microsoft.EntityFrameworkCore;

namespace Eticaretproject.Models
{
    public partial class EticaretContext : DbContext
    {
        public EticaretContext()
        {
        }

        public EticaretContext(DbContextOptions<EticaretContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }
        public virtual DbSet<Oneriler> Onerilers { get; set; }
        public virtual DbSet<Sepet> Sepets { get; set; }
        public virtual DbSet<Siparisdetayi> Siparisdetayis { get; set; }
        public virtual DbSet<Siparisler> Siparislers { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-3V3DAFM\\SQLEXPRESS;Database=ETicaret;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategoriler>(entity =>
            {
                entity.HasKey(e => e.KategoriId);
                entity.ToTable("kategoriler");

                entity.Property(e => e.KategoriId).HasColumnName("kategoriID");
                entity.Property(e => e.KategoriAdi).HasMaxLength(100);
            });

            modelBuilder.Entity<Kullanicilar>(entity =>
            {
                entity.HasKey(e => e.KullaniciId);
                entity.ToTable("kullanicilar");

                entity.Property(e => e.KullaniciId)
                    .ValueGeneratedNever()
                    .HasColumnName("kullaniciID");
                entity.Property(e => e.AdSoyad).HasMaxLength(100);
                entity.Property(e => e.Eposta).HasMaxLength(100);
                entity.Property(e => e.SifreHash).HasMaxLength(250);
            });

            modelBuilder.Entity<Oneriler>(entity =>
            {
                entity.HasKey(e => e.OneriId);
                entity.ToTable("oneriler");

                entity.Property(e => e.OneriId)
                    .ValueGeneratedNever()
                    .HasColumnName("OneriID");
                entity.Property(e => e.Gerekce).HasMaxLength(255);
                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");
                entity.Property(e => e.UrunId).HasColumnName("UrunID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Onerilers)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK__oneriler__Kullan__45F365D3");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Onerilers)
                    .HasForeignKey(d => d.UrunId)
                    .HasConstraintName("FK_oneriler_Urun");
            });

            modelBuilder.Entity<Sepet>(entity =>
            {
                entity.HasKey(e => e.SepetId);
                entity.ToTable("sepet");

                entity.Property(e => e.SepetId).HasColumnName("SepetID");
                entity.Property(e => e.Adet).HasDefaultValue(1);
                entity.Property(e => e.EklemeTarihi)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");
                entity.Property(e => e.UrunId).HasColumnName("UrunID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Sepets)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sepet_Kullanici");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Sepets)
                    .HasForeignKey(d => d.UrunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sepet_Urun");
            });

            modelBuilder.Entity<Siparisdetayi>(entity =>
            {
                entity.HasKey(e => e.SiparisDetayiId);
                entity.ToTable("siparisdetayi");

                entity.Property(e => e.SiparisDetayiId)
                    .ValueGeneratedNever()
                    .HasColumnName("SiparisDetayiID");
                entity.Property(e => e.SiparisAnindakiFiyat).HasColumnType("decimal(10, 2)");
                entity.Property(e => e.SiparisId).HasColumnName("SiparisID");
                entity.Property(e => e.UrunId).HasColumnName("UrunID");

                entity.HasOne(d => d.Siparis)
                    .WithMany(p => p.Siparisdetayis)
                    .HasForeignKey(d => d.SiparisId)
                    .HasConstraintName("FK__siparisde__Sipar__4222D4EF");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Siparisdetayis)
                    .HasForeignKey(d => d.UrunId)
                    .HasConstraintName("FK_siparisdetayi_Urun");
            });

            modelBuilder.Entity<Siparisler>(entity =>
            {
                entity.HasKey(e => e.SiparisId);
                entity.ToTable("siparisler");

                entity.Property(e => e.SiparisId)
                    .ValueGeneratedNever()
                    .HasColumnName("SiparisID");
                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");
                entity.Property(e => e.SiparisTarihi)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Siparislers)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK__siparisle__Kulla__3F466844");
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId);
                entity.ToTable("urunler");

                entity.Property(e => e.UrunId).HasColumnName("urunID");
                entity.Property(e => e.UrunAdi).HasMaxLength(100);
                entity.Property(e => e.Aciklama);
                entity.Property(e => e.Fiyat).HasColumnType("decimal(10, 2)");
                entity.Property(e => e.Stok);
                entity.Property(e => e.KategoriId).HasColumnName("kategoriID");
                entity.Property(e => e.ResimUrl)
                      .HasMaxLength(255)
                      .HasColumnName("ResimURL");

                entity.HasOne(d => d.Kategoriler)
                    .WithMany(p => p.Urunlers)
                    .HasForeignKey(d => d.KategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_urunler_kategori");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
