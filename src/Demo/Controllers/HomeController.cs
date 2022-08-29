using Demo.Models;
using Demo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly IEmploye _employe;

        public HomeController(ILogger<HomeController> logger,IEmploye employe)
        {
            _logger = logger;
            _employe = employe;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string Getemp(int id)
        {
            return _employe.GetId(id).Name;
        }
        public IActionResult GetInfo()
        {
            var emplist = _employe.EmployeeList();
            return View(emplist);


        }
        public IActionResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel();
            homeDetailsViewModel.Employee = _employe.GetId(id);
            homeDetailsViewModel.PageTitle = "This Employee Management System";

            return View(homeDetailsViewModel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}