using MabizelaLB_Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MabizelaLB_Assignment1.Data
{
    public interface IBooksRepository
    {
        void AddBook(Book book);
        IEnumerable<Book> AllBooks { get; }
    }
}
