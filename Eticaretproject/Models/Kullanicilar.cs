using System;
using System.Collections.Generic;

namespace Eticaretproject.Models;

public partial class Kullanicilar
{
    public int KullaniciId { get; set; }

    public string? AdSoyad { get; set; }

    public string? Eposta { get; set; }

    public string? SifreHash { get; set; }

    public virtual ICollection<Oneriler> Onerilers { get; set; } = new List<Oneriler>();

    public virtual ICollection<Sepet> Sepets { get; set; } = new List<Sepet>();

    public virtual ICollection<Siparisler> Siparislers { get; set; } = new List<Siparisler>();
}
