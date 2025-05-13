using System;
using System.Collections.Generic;

namespace Eticaretproject.Models;

public partial class Sepet
{
    public int SepetId { get; set; }

    public int KullaniciId { get; set; }

    public int UrunId { get; set; }

    public int Adet { get; set; }

    public DateTime EklemeTarihi { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual Urunler Urun { get; set; } = null!;
}
