using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TC3Core.Domain.Classes.Stash;

namespace TC3Core.Services
{
    public class MemoryBookData : IBookData
    {
        List<Book> _books;
        public MemoryBookData()
        {
            _books = new List<Book> {
                //TODO: Populate with meaningful data
                new Book {ID = Guid.NewGuid(),Cataloged = null,DateInventoried = null,DatePurchased = null,DateVerified = null,Location = null,Notes = string.Empty,Price = null,Value = null,WishList = null,
                            AlphaSort = "",Author = "",MediaFormat = "",ISBN = "",Misc = "",Subject = "",Title = ""},
                new Book {ID = Guid.NewGuid(), Cataloged = null,DateInventoried = null,DatePurchased = null,DateVerified = null,Location = null,Notes = string.Empty,Price = null,Value = null,WishList = null,
                            AlphaSort = "",Author = "",MediaFormat = "",ISBN = "",Misc = "",Subject = "",Title = ""},
                new Book {ID = Guid.NewGuid(), Cataloged = null,DateInventoried = null,DatePurchased = null,DateVerified = null,Location = null,Notes = string.Empty,Price = null,Value = null,WishList = null,
                            AlphaSort = "",Author = "",MediaFormat = "",ISBN = "",Misc = "",Subject = "",Title = ""}
            };
        }
        public Book Add(Book book)
        {
            book.ID = Guid.NewGuid();
            _books.Add(book);
            return book;
        }
        public Book Get(Guid id)
        {
            return _books.FirstOrDefault(r => r.ID == id);
        }
        public IEnumerable<Book> GetAll()
        {
            return _books.OrderBy(r => r.AlphaSort);
        }
        public Book Update(Book book)
        {
            //TODO: Implement Memory incarnation of Update
            throw new NotImplementedException();
        }
    }
}
