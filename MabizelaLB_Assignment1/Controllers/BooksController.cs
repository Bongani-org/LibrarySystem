using MabizelaLB_Assignment1.Data;
using MabizelaLB_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MabizelaLB_Assignment1.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksRepository _booksRepository;

        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                _booksRepository.AddBook(book);
                return View("Confirmation", book);
            }
            else
            {
                return View(book);
            }
        }
        
        public ViewResult Confirmation()
        {
            return View();
        }

        public ViewResult Library()
        {
            return View(_booksRepository.AllBooks.OrderBy(b => b.BookTitle));
        }

    }
}
