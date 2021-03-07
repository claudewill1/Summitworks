using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Summitworks_Project.Models;
using Summitworks_Project.ViewModels;

namespace Summitworks_Project.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepository;
        private readonly ILogger logger;

        public HomeController(IBookRepository bookRepository, ILogger<HomeController> logger)
        {
            _bookRepository = bookRepository;
            this.logger = logger;
        }
        

        public ViewResult Index()
        {
            var model = _bookRepository.GetAllBooks();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            //throw new Exception("Error in details");
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");
            
            Book book = _bookRepository.GetBook(id);

            if (book == null)
            {
                Response.StatusCode = 404;
                return View("BookNotFound", id);
            }
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            { 
                Book = book,
                PageTitle = "Book Details"
            };
            //Book model = _bookRepository.GetBook(1);
            
            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                Book newBook = _bookRepository.Add(book);
                return RedirectToAction("details", new { id = newBook.Id });
            }
            else
            {
                return View();
            }
        }
    }
}
