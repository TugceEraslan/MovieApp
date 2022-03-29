using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class MovieController : Controller      /* MovieController içerisinde Admin'in yapması gereken işleri yapalım. 
                                                    * Yönetici sayfaları içinde MovieController sayfasını kullanılır */
    {
        public IActionResult Index()       // Kullanıcıya ilk gösterilen alan( Bütün Movie bilgilerini gösterir )
        {
            return View();
        }

        public IActionResult Create()      // Kayıt ekleme işlemi yapalım
        {
            return View();
        }

        public IActionResult Details()    // Detay bilgileri için
        {
            return View();
        }

        public IActionResult List()       // Listeleme işlemi yapalım
        {
            return View();
        }
    }
}
