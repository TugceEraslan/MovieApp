using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public static class MovieRepository  // Repository static olacak yani bir örnek oluşturulamayan. Sadece uygulamaya özel bir Repository sınıfının olacağı yapı
    {


        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()    // Movie içerisine örnek bir liste ekleyeceğim
            {
                // Liste içerisine bir film listesi ekleyelim
                new Movie() 
                { 
                    Id=1, 
                    Name="Shazam", 
                    ShortDescription="Shazam",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>", 
                    ImageUrl="1.jpg",
                    CategoryId=1
                },
                new Movie() 
                { 
                    Id=2, 
                    Name="Amazing Grace",
                    ShortDescription="Amazing Grace",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>", 
                    ImageUrl="2.jpg",
                    CategoryId=2
                },
                new Movie() 
                { 
                    Id=3, 
                    Name="High Life",
                    ShortDescription="High Life",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>", 
                    ImageUrl="3.jpg",
                    CategoryId=2,
                },
                new Movie() 
                { 
                    Id=4, 
                    Name="Billboard",
                    ShortDescription="Billboard",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>", 
                    ImageUrl="4.jpg",
                    CategoryId=3
                },
                new Movie() 
                {
                    Id=5, 
                    Name="Storm Boy",
                    ShortDescription="Storm Boy",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>",
                    ImageUrl="5.jpg",
                    CategoryId=3
                }
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
