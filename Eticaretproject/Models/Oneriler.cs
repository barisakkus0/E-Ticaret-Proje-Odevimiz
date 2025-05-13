using System;
using System.Collections.Generic;

namespace Eticaretproject.Models;

public partial class Oneriler
{
    // propeties
    public int OneriId { get; set; }

    public int? KullaniciId { get; set; }

    public int? UrunId { get; set; }

    public string? Gerekce { get; set; }

    public virtual Kullanicilar? Kullanici { get; set; }

    public virtual Urunler? Urun { get; set; }
}
