using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class HomeController : Controller  /* Kullanıcı sayfaları için HomeController kullanılır */
    {
        public IActionResult Index()  // Kullanıcı anasayfaya geldiğinde sadece onaylı movie bilgilerini görebilir
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        } 
    }
}
