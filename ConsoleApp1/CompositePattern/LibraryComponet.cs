using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface Library
    {

        public void ShowInfo();
    }
    public class Category : Library
    {
        protected List<Library> _library = new List<Library>();
        protected string _categoryName = string.Empty;
        protected string _libraryName = string.Empty;
        protected bool _isBook { get; set; }
        protected bool _isDVD  { get; set; }
        public Category(string libraryName, string categoryName, bool isBook ,bool isDvd)
        {
            this._libraryName = libraryName;
            this._categoryName = categoryName;
            this._isBook = isBook;
            this._isDVD = isDvd;
        }


        public void AddComponent(Library library)
        {

            if (_library == null)
            {
                _library = new List<Library>();
            }

            if (library != null)
            {
                _library.Add(library);
            }

        }
        public void RemoveComponent(Library library)
        {
            if (_library != null)
            {
                if (library != null)
                {
                    _library.Remove(library);
                }
            }

           
        }

        public void ShowInfo()
        {

            if (_libraryName != string.Empty)
            {
                Console.WriteLine($"LibraryName  {_libraryName}");
            }
            if (_isBook)
            {
                Console.WriteLine($"-------------- Book Category {_categoryName} ------------------");
            }
            if (_isDVD)
            {
                Console.WriteLine($"-------------- DVD Category {_categoryName} ------------------");
            }
          

            foreach (Library library in _library)
            {

                library.ShowInfo();
            }

        }
    }

    public class Book : Library
    {
        private string title;
        private string author;
        private string isbn;
        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Book Title : {this.title} , author : {author} , isbh {isbn}");
        }
    }
    
    public class DVD : Library
    {
        private string title;
        private string director;
        private string releaseYear;
        public DVD(string title, string director, string releaseYear) 
        {
            this.title = title;
            this.director = director;
            this.releaseYear = releaseYear;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"DVD Title : {this.title} , Director : {director} , isbh {releaseYear}");
        }

    }




}
