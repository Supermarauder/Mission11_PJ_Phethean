using Microsoft.AspNetCore.Mvc;
using Mission11_PJ_Phethean.Models;
using Mission11_PJ_Phethean.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_PJ_Phethean.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }


        public IActionResult Index(int pageNum) // Pagination
        {
            int pageSize = 10;

            var ViewModel = new BookListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(ViewModel);
        }


    }
}
