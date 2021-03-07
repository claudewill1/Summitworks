using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summitworks_Project.Models
{
    public class MockBookRepository : IBookRepository
    {
        private List<Book> _bookList;
        
        public MockBookRepository()
        {
            _bookList = new List<Book>()
            {
                new Book() {Id=1,BookName="The Trials of Apollo", BookAuthor="Rick Riordan",BookCategory=Category.Fantasy},
                new Book() {Id=2,BookName="Circe",BookAuthor="Madeline Miller", BookCategory=Category.Fantasy},
                new Book() {Id=3,BookName="The Castle of Adventure",BookAuthor="Enid Blyton",BookCategory=Category.Childrens_Literature}
            };
        }

        public Book Add(Book book)
        {
            book.Id=_bookList.Max(b => b.Id) + 1;
            _bookList.Add(book);
            return book;
        }

        public Book Delete(int id)
        {
            Book book = _bookList.FirstOrDefault(b => b.Id == id);
            if(book != null)
            {
                _bookList.Remove(book);
            }
            return book;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookList;
        }

        public Book GetBook(int Id)
        {
            return _bookList.FirstOrDefault(b => b.Id == Id);
        }

        public Book Update(Book bookChanges)
        {
            Book book = _bookList.FirstOrDefault(b => b.Id == bookChanges.Id);
            if (book != null)
            {
                book.BookName = bookChanges.BookName;
                book.BookAuthor = bookChanges.BookAuthor;
                book.BookCategory = bookChanges.BookCategory;

            }
            return book;
        }
    }
}
