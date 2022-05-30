using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
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
            return View(Repository.Movies);   // Repository.Movies bilgileri bana Index e getirdi.
                                              // Ama index.cshtml inden de bu bilgileri almak için index.cshtml üzerinde de model oluşturmam gerekir
        }

        public IActionResult Details(int id)   // _movies.cshtml de ki  asp-route-id="@movie.Id" için home controller daki details action undan beklenen id olacak
        {
            return View(Repository.GetById(id));   // GetById(id) benden Details avtion undan gönderilen id parametresi bekliyor
                                                   // ve bende bu id gönderince Repository.GetById(id) ile bana tek bir movie gönderiyor
        }

        public IActionResult Contact()
        {
            return View();
        } 
    }
}
