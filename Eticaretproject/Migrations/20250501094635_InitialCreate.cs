using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eticaretproject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_EticaretContext",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EticaretContext", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EticaretContextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kategoriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Kategoriler__EticaretContext_EticaretContextId",
                        column: x => x.EticaretContextId,
                        principalTable: "_EticaretContext",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SifreHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EticaretContextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kullanicilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Kullanicilar__EticaretContext_EticaretContextId",
                        column: x => x.EticaretContextId,
                        principalTable: "_EticaretContext",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Stok = table.Column<int>(type: "int", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: true),
                    ResimUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EticaretContextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Urunler__EticaretContext_EticaretContextId",
                        column: x => x.EticaretContextId,
                        principalTable: "_EticaretContext",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Urunler__Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "_Kategoriler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_Siparisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EticaretContextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Siparisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Siparisler__EticaretContext_EticaretContextId",
                        column: x => x.EticaretContextId,
                        principalTable: "_EticaretContext",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Siparisler__Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "_Kullanicilar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_Oneriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OneriId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    UrunId = table.Column<int>(type: "int", nullable: true),
                    Gerekce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EticaretContextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Oneriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Oneriler__EticaretContext_EticaretContextId",
                        column: x => x.EticaretContextId,
                        principalTable: "_EticaretContext",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Oneriler__Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "_Kullanicilar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Oneriler__Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "_Urunler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_Siparisdetayi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisDetayiId = table.Column<int>(type: "int", nullable: false),
                    SiparisId = table.Column<int>(type: "int", nullable: true),
                    UrunId = table.Column<int>(type: "int", nullable: true),
                    Adet = table.Column<int>(type: "int", nullable: true),
                    SiparisAnindakiFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EticaretContextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Siparisdetayi", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Siparisdetayi__EticaretContext_EticaretContextId",
                        column: x => x.EticaretContextId,
                        principalTable: "_EticaretContext",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Siparisdetayi__Siparisler_SiparisId",
                        column: x => x.SiparisId,
                        principalTable: "_Siparisler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Siparisdetayi__Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "_Urunler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX__Kategoriler_EticaretContextId",
                table: "_Kategoriler",
                column: "EticaretContextId");

            migrationBuilder.CreateIndex(
                name: "IX__Kullanicilar_EticaretContextId",
                table: "_Kullanicilar",
                column: "EticaretContextId");

            migrationBuilder.CreateIndex(
                name: "IX__Oneriler_EticaretContextId",
                table: "_Oneriler",
                column: "EticaretContextId");

            migrationBuilder.CreateIndex(
                name: "IX__Oneriler_KullaniciId",
                table: "_Oneriler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX__Oneriler_UrunId",
                table: "_Oneriler",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX__Siparisdetayi_EticaretContextId",
                table: "_Siparisdetayi",
                column: "EticaretContextId");

            migrationBuilder.CreateIndex(
                name: "IX__Siparisdetayi_SiparisId",
                table: "_Siparisdetayi",
                column: "SiparisId");

            migrationBuilder.CreateIndex(
                name: "IX__Siparisdetayi_UrunId",
                table: "_Siparisdetayi",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX__Siparisler_EticaretContextId",
                table: "_Siparisler",
                column: "EticaretContextId");

            migrationBuilder.CreateIndex(
                name: "IX__Siparisler_KullaniciId",
                table: "_Siparisler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX__Urunler_EticaretContextId",
                table: "_Urunler",
                column: "EticaretContextId");

            migrationBuilder.CreateIndex(
                name: "IX__Urunler_KategoriId",
                table: "_Urunler",
                column: "KategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Oneriler");

            migrationBuilder.DropTable(
                name: "_Siparisdetayi");

            migrationBuilder.DropTable(
                name: "_Siparisler");

            migrationBuilder.DropTable(
                name: "_Urunler");

            migrationBuilder.DropTable(
                name: "_Kullanicilar");

            migrationBuilder.DropTable(
                name: "_Kategoriler");

            migrationBuilder.DropTable(
                name: "_EticaretContext");
        }
    }
}
