using MabizelaLB_Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MabizelaLB_Assignment1.Data
{
    public class BooksRepository : IBooksRepository
    {
        private readonly AppDbContext _appDbContext;
        public BooksRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> AllBooks => _appDbContext.Books;

        public void AddBook(Book book)
        {
            _appDbContext.Books.Add(book);
            _appDbContext.SaveChanges();
        }

    }
}
