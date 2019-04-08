using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TC3Core.Data;
using TC3Core.Domain.Classes.Stash;

namespace TC3Core.Services
{
    public class SqlBookData : IBookData
    {
        //private List<Book>_books;
        private TC3DbContext _context;
        public SqlBookData(TC3DbContext context)
        {
            _context = context;
        }
        public Book Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }
        public Book Get(Guid id)
        {
            return _context.Books.FirstOrDefault(r => r.ID == id);
        }
        public IEnumerable<Book> GetAll()
        {
            //return _context.Books.OrderBy(r => r.AlphaSort);
            return _context.Books;
        }
        public Book Update(Book book)
        {
            _context.Attach(book).State = EntityState.Modified;
            _context.SaveChanges();
            return book;
        }
    }
}
