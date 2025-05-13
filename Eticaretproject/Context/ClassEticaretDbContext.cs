using Eticaretproject.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.Identity.Client;

namespace Eticaretproject.Context
{
    public class ClassEticaretDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-64KCFSH\\SQLEXPRESS;database = Nesneg19;Integrated Security = True ;TrustServerSertificate=True;");
        }

        public DbSet<Urunler> _Urunler { get; set; }
        public DbSet<Siparisler> _Siparisler { get; set; }
        public DbSet<Siparisdetayi> _Siparisdetayi { get; set; }
        public DbSet<Oneriler> _Oneriler { get; set; }
        public DbSet<Kullanicilar> _Kullanicilar { get; set; }
        public DbSet<Kategoriler> _Kategoriler { get; set; }
        // Removed the problematic DbSet<EticaretContext> _EticaretContext
    }
}
