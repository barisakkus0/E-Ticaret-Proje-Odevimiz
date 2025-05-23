﻿// <auto-generated />
using System;
using Eticaretproject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eticaretproject.Migrations
{
    [DbContext(typeof(ClassEticaretDbContext))]
    [Migration("20250501094635_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Eticaretproject.Models.EticaretContext", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("_EticaretContext");
                });

            modelBuilder.Entity("Eticaretproject.Models.Kategoriler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EticaretContextId")
                        .HasColumnType("int");

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EticaretContextId");

                    b.ToTable("_Kategoriler");
                });

            modelBuilder.Entity("Eticaretproject.Models.Kullanicilar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EticaretContextId")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("SifreHash")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EticaretContextId");

                    b.ToTable("_Kullanicilar");
                });

            modelBuilder.Entity("Eticaretproject.Models.Oneriler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EticaretContextId")
                        .HasColumnType("int");

                    b.Property<string>("Gerekce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("OneriId")
                        .HasColumnType("int");

                    b.Property<int?>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EticaretContextId");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("UrunId");

                    b.ToTable("_Oneriler");
                });

            modelBuilder.Entity("Eticaretproject.Models.Siparisdetayi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Adet")
                        .HasColumnType("int");

                    b.Property<int?>("EticaretContextId")
                        .HasColumnType("int");

                    b.Property<decimal?>("SiparisAnindakiFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SiparisDetayiId")
                        .HasColumnType("int");

                    b.Property<int?>("SiparisId")
                        .HasColumnType("int");

                    b.Property<int?>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EticaretContextId");

                    b.HasIndex("SiparisId");

                    b.HasIndex("UrunId");

                    b.ToTable("_Siparisdetayi");
                });

            modelBuilder.Entity("Eticaretproject.Models.Siparisler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EticaretContextId")
                        .HasColumnType("int");

                    b.Property<int?>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("SiparisId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SiparisTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EticaretContextId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("_Siparisler");
                });

            modelBuilder.Entity("Eticaretproject.Models.Urunler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EticaretContextId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("ResimUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Stok")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EticaretContextId");

                    b.HasIndex("KategoriId");

                    b.ToTable("_Urunler");
                });

            modelBuilder.Entity("Eticaretproject.Models.Kategoriler", b =>
                {
                    b.HasOne("Eticaretproject.Models.EticaretContext", null)
                        .WithMany("Kategorilers")
                        .HasForeignKey("EticaretContextId");
                });

            modelBuilder.Entity("Eticaretproject.Models.Kullanicilar", b =>
                {
                    b.HasOne("Eticaretproject.Models.EticaretContext", null)
                        .WithMany("Kullanicilars")
                        .HasForeignKey("EticaretContextId");
                });

            modelBuilder.Entity("Eticaretproject.Models.Oneriler", b =>
                {
                    b.HasOne("Eticaretproject.Models.EticaretContext", null)
                        .WithMany("Onerilers")
                        .HasForeignKey("EticaretContextId");

                    b.HasOne("Eticaretproject.Models.Kullanicilar", "Kullanici")
                        .WithMany("Onerilers")
                        .HasForeignKey("KullaniciId");

                    b.HasOne("Eticaretproject.Models.Urunler", "Urun")
                        .WithMany("Onerilers")
                        .HasForeignKey("UrunId");

                    b.Navigation("Kullanici");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Eticaretproject.Models.Siparisdetayi", b =>
                {
                    b.HasOne("Eticaretproject.Models.EticaretContext", null)
                        .WithMany("Siparisdetayis")
                        .HasForeignKey("EticaretContextId");

                    b.HasOne("Eticaretproject.Models.Siparisler", "Siparis")
                        .WithMany("Siparisdetayis")
                        .HasForeignKey("SiparisId");

                    b.HasOne("Eticaretproject.Models.Urunler", "Urun")
                        .WithMany("Siparisdetayis")
                        .HasForeignKey("UrunId");

                    b.Navigation("Siparis");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Eticaretproject.Models.Siparisler", b =>
                {
                    b.HasOne("Eticaretproject.Models.EticaretContext", null)
                        .WithMany("Siparislers")
                        .HasForeignKey("EticaretContextId");

                    b.HasOne("Eticaretproject.Models.Kullanicilar", "Kullanici")
                        .WithMany("Siparislers")
                        .HasForeignKey("KullaniciId");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Eticaretproject.Models.Urunler", b =>
                {
                    b.HasOne("Eticaretproject.Models.EticaretContext", null)
                        .WithMany("Urunlers")
                        .HasForeignKey("EticaretContextId");

                    b.HasOne("Eticaretproject.Models.Kategoriler", "Kategori")
                        .WithMany("Urunlers")
                        .HasForeignKey("KategoriId");

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Eticaretproject.Models.EticaretContext", b =>
                {
                    b.Navigation("Kategorilers");

                    b.Navigation("Kullanicilars");

                    b.Navigation("Onerilers");

                    b.Navigation("Siparisdetayis");

                    b.Navigation("Siparislers");

                    b.Navigation("Urunlers");
                });

            modelBuilder.Entity("Eticaretproject.Models.Kategoriler", b =>
                {
                    b.Navigation("Urunlers");
                });

            modelBuilder.Entity("Eticaretproject.Models.Kullanicilar", b =>
                {
                    b.Navigation("Onerilers");

                    b.Navigation("Siparislers");
                });

            modelBuilder.Entity("Eticaretproject.Models.Siparisler", b =>
                {
                    b.Navigation("Siparisdetayis");
                });

            modelBuilder.Entity("Eticaretproject.Models.Urunler", b =>
                {
                    b.Navigation("Onerilers");

                    b.Navigation("Siparisdetayis");
                });
#pragma warning restore 612, 618
        }
    }
}
