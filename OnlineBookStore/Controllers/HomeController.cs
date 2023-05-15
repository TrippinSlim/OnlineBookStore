using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;
using OnlineBookStore.Models.ViewModels;

namespace OnlineBookStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(string? category, int bookPage = 1) => View(new BooksListViewModel
        {
            Books = repository.Books.Where(b => category == null || b.Category == category).OrderBy(b => b.BookID).Skip((bookPage - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo 
            { 
                CurrentPage = bookPage, 
                ItemsPerPage = PageSize,
                TotalItems = category == null ? repository.Books.Count() : repository.Books.Where(e => e.Category == category).Count()
            },
            CurrentCategory = category
        });
    }
}