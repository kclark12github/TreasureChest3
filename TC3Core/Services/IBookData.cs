using System;
using System.Collections.Generic;
using TC3Core.Domain.Classes.Stash;

namespace TC3Core.Services
{
    public interface IBookData
    {
        IEnumerable<Book> GetAll();
        Book Get(Guid id);
        Book Add(Book book);
        Book Update(Book book);
    }
}
