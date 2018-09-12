using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

namespace UrlsAndRoutes.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            return View("Result", new Result { Controller = nameof(AdminController), Action = nameof(Index) });
        }
    }
}