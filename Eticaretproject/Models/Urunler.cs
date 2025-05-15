using System.Collections.Generic;

namespace Eticaretproject.Models
{
    public class Urunler
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public int KategoriId { get; set; }
        public string ResimUrl { get; set; }

        public virtual Kategoriler Kategoriler { get; set; }
        public virtual ICollection<Sepet> Sepets { get; set; }
        public virtual ICollection<Siparisdetayi> Siparisdetayis { get; set; }
        public virtual ICollection<Oneriler> Onerilers { get; set; }
    }
}
