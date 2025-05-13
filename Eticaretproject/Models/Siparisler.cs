using System;
using System.Collections.Generic;

namespace Eticaretproject.Models;

public partial class Siparisler
{
    public int SiparisId { get; set; }

    public int? KullaniciId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public virtual Kullanicilar? Kullanici { get; set; }

    public virtual ICollection<Siparisdetayi> Siparisdetayis { get; set; } = new List<Siparisdetayi>();
}
