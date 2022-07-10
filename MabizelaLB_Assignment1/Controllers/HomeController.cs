using MabizelaLB_Assignment1.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MabizelaLB_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBooksRepository _booksRepository;
        public HomeController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
