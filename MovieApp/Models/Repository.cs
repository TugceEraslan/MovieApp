using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public static class Repository  // Repository static olacak yani bir örnek oluşturulamayan. Sadece uygulamaya özel bir Repository sınıfının olacağı yapı
    {


        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()    // Movie içerisine örnek bir liste ekleyeceğim
            {
                // Liste içerisine bir film listesi ekleyelim
                new Movie() { Id=1, Name="Shazam", Description="Shazam", ImageUrl="1.jpg"},
                new Movie() { Id=2, Name="Amazing Grace", Description="Amazing Grace", ImageUrl="2.jpg"},
                new Movie() { Id=3, Name="High Life", Description="High Life", ImageUrl="3.jpg"},
                new Movie() { Id=4, Name="Billboard", Description="Billboard", ImageUrl="4.jpg"},
                new Movie() { Id=5, Name="Storm Boy", Description="Storm Boy", ImageUrl="5.jpg"}


            };
        }
        //Repository.movies dediğimde bana bilgi getirmesi gerek
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        // Liste üzerine bir eleman eklemek için 
        public static void AddMovie(Movie entity)  // Dışardan bir Movie objesi alsın ona da entity diyelim
        {
            _movies.Add(entity);
        }

        //Movie yi dışardan istersek ve geriye bir Movie objesi göndereceksek "public static Movie GetById(int id)" şeklinde yazarız.
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id); // FirstOrDefault ile arama yaptık.
                                                            // Her bir elemanı i içerisine kopyaladım.(Gönderilen her bir _movies yi i nin içine kopyalar)
                                                            // i nin kendi Id si ile dışardan gelen id aynıysa bunu döndürelim. Bir değer bulamazsa geriye null değer gelir                                                
        }

    }
}
