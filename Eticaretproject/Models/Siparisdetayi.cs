using System;
using System.Collections.Generic;

namespace Eticaretproject.Models;

public partial class Siparisdetayi
{
    public int SiparisDetayiId { get; set; }

    public int? SiparisId { get; set; }

    public int? UrunId { get; set; }

    public int? Adet { get; set; }

    public decimal? SiparisAnindakiFiyat { get; set; }

    public virtual Siparisler? Siparis { get; set; }

    public virtual Urunler? Urun { get; set; }
}
