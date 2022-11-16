using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var pieOfTheWeek = _pieRepository.PieOfTheWeek;

            var homeViewModel = new HomeViewModel(pieOfTheWeek);
            return View(homeViewModel);
        }
    }
}
