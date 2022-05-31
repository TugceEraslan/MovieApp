using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()   // Bize data getirecek olan metodumuz
        {
            return View(CategoryRepository.Categories);
        }
    }
}
