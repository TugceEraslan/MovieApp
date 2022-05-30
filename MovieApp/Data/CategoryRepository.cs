using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()   // CategoryRepository miz dışarıya aşağıdaki gibi kategori bilgilerini verecek
            {
                new Category() { Id=1,Name="Macera" },
                new Category() { Id=2,Name="Romantik" },
                new Category() { Id=3,Name="Bilim Kurgu" },
                new Category() { Id=4,Name="Savaş" },
                new Category() { Id=5,Name="Komedi" },
            };
        }
        //Repository.categories dediğimde bana bilgi getirmesi gerek
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        // Liste üzerine bir eleman eklemek için 
        public static void AddCategory(Category entity)  // Dışardan bir Movie objesi alsın ona da entity diyelim
        {
            _categories.Add(entity);
        }

        //Movie yi dışardan istersek ve geriye bir Movie objesi göndereceksek "public static Movie GetById(int id)" şeklinde yazarız.
        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id); // FirstOrDefault ile arama yaptık.
                                                            // Her bir elemanı i içerisine kopyaladım.(Gönderilen her bir _categories in içine kopyalar)
                                                            // i nin kendi Id si ile dışardan gelen id aynıysa bunu döndürelim. Bir değer bulamazsa geriye null değer gelir                                                
        }
    }
}
