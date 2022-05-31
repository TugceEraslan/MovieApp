using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class HomeController : Controller  /* Kullanıcı sayfaları için HomeController kullanılır */
    {
       // Home/Index/3
        public IActionResult Index(int? id)  // Kullanıcı anasayfaya geldiğinde sadece onaylı movie bilgilerini görebilir
        {
            var movies = MovieRepository.Movies;

            if(id!=null)  // id null dan farklı ise filtreleme yapmamız gerekir
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }

            return View(movies);        
        }

        public IActionResult Details(int id)   // _movies.cshtml de ki  asp-route-id="@movie.Id" için home controller daki details action undan beklenen id olacak
        {
            MovieCategoryModel model = new MovieCategoryModel();
            model.Categories = CategoryRepository.Categories;
            model.Movie = MovieRepository.GetById(id);

            return View(MovieRepository.GetById(id));   // Tek bir movie bilgisini sayfaya göndermek
            //return View(MovieRepository.GetById(id));   // GetById(id) benden Details action undan gönderilen id parametresi bekliyor
                                                   // ve bende bu id gönderince Repository.GetById(id) ile bana tek bir movie gönderiyor.Sayfaya tek bir model
                                                   //göndermektense model gönderelim
        }

        public IActionResult Contact()
        {
            return View();
        } 
    }
}
