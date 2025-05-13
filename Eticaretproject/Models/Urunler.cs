using System;
using System.Collections.Generic;

namespace Eticaretproject.Models;

public partial class Urunler
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public decimal Fiyat { get; set; }

    public int Stok { get; set; }



    public int KategoriId { get; set; }

    public string? ResimUrl { get; set; }

    public virtual ICollection<Oneriler> Onerilers { get; set; } = new List<Oneriler>();

    public virtual ICollection<Sepet> Sepets { get; set; } = new List<Sepet>();

    public virtual ICollection<Siparisdetayi> Siparisdetayis { get; set; } = new List<Siparisdetayi>();
    public virtual Kategoriler Kategori { get; set; } = null!;

}
