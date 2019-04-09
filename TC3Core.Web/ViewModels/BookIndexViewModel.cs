using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TC3Core.Domain.Classes.Stash;

namespace TC3Core.ViewModels
{
    public class BookIndexViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
