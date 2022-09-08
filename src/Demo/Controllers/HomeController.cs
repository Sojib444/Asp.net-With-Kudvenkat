using Demo.Models;
using Demo.Models.Teacher;
using Demo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly IEmploye _employe;
        public readonly ITeacher _teacher;

        public HomeController(ILogger<HomeController> logger,IEmploye employe,ITeacher teacher)
        {
            _logger = logger;
            _employe = employe;
            _teacher = teacher;
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
        public IActionResult TeacherList()
        {
            List<Teacher> teachers = _teacher.getTeacher();
            return View(teachers);


        }
        public IActionResult SpecificTeacher( int id)
        {
           Teacher teacher= _teacher.specificTeacher(id);
            
            return View(teacher);

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