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

        // {controller}/{action}/{id?}
        // home/index/3

        // RouteData.Values["controller"]=> controller yerine-> home  (Yukardaki örnek tanıma göre)
        // RouteData.Values["action"]=> action yerine -> index
        // RouteData.Values["id"]=> id -> 3
        public IViewComponentResult Invoke()   // Bize data getirecek olan metodumuz
        {
            if(RouteData.Values["action"].ToString() == "Index")   // Sadece Index action nındayken viewbag içerisi doldurulur.
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            // Invoke metodu çalıştığı zaman o anki url içerisndeki id parametresi alınır
            // Geçici alan yani Viewbag içine atılır ve SelectedCategory diye bir alan Viewbag içinde oluşturulur ve ilgili id değeri aktarılır

            return View(CategoryRepository.Categories);
        }
    }
}
