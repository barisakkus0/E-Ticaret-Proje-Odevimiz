    using System.Diagnostics;
    using Eticaretproject.Models;
    using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore; // Include için gerekli
    using Microsoft.Extensions.Logging; // ILogger için gerekli

    namespace Eticaretproject.Controllers

    {
        public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;
            private readonly EticaretContext _context;

            public HomeController(ILogger<HomeController> logger, EticaretContext context)
            {
                _logger = logger;
                _context = context;
            }

            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Privacy()
            {
                return View();
            }
            public IActionResult Login()
            {
                return View();
            }
            public IActionResult SignUp()
            {
                return View();
            }
            public IActionResult Sepet()
            {
                return View();
            }
            public IActionResult Odeme()
            {
                return View();
            }
        public IActionResult Admin()
            {
                return View();
            }

        public IActionResult Urunler()
        {
            ViewBag.Kategoriler = _context.Kategorilers.ToList(); // Kategorileri ViewBag'e gönder
            var urunler = _context.Urunlers.Include(u => u.Kategoriler).ToList(); // Ürünleri kategoriyle birlikte getir
            return View(urunler);
        }


        public IActionResult Kategoriler()
            {
                var kategoriler = _context.Kategorilers.ToList();
                return View(kategoriler);
            }

            public IActionResult Kullanicilar()
            {
                var kullanicilar = _context.Kullanicilars.ToList();
                return View(kullanicilar);
            }



            public IActionResult Siparisler()
            {
                // Siparişleri kullanıcı bilgileriyle birlikte getiriyoruz
                var siparisler = _context.Siparislers.Include(s => s.Kullanici).ToList();
                return View(siparisler);
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }

        public IActionResult UrunEkle()
        {
            ViewBag.Kategoriler = new SelectList(_context.Kategorilers.ToList(), "KategoriId", "KategoriAdi");
            return View();
        }
        // get ve post metodları ile ürün ekleme işlemi

        [HttpPost]
        public IActionResult UrunEkle(Urunler urun)
        {
            if (ModelState.IsValid)
            {
                _context.Urunlers.Add(urun);
                _context.SaveChanges();
                return RedirectToAction("Urunler");
            }
            ViewBag.Kategoriler = new SelectList(_context.Kategorilers.ToList(), "KategoriId", "KategoriAdi");
            return View(urun); 
        }




    }
}