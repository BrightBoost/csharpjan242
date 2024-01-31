using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.objectsMethodsOOP.BookLibrarySystem
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public bool RemoveBook(string title)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book != null)
            {
                books.Remove(book);
                return true;
            }
            return false;
        }

        public IEnumerable<Book> FindBooksByAuthor(string author)
        {
            return books.Where(b => b.Author == author);
        }
    }
}
