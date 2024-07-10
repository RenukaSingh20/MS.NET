using Microsoft.AspNetCore.Mvc;
using StudentApp.Services;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService {  get; set; }
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            List<Student> students = _studentService.GetAll();
            return View();
        }
        public IActionResult GetAll()
        {
            return View();
        }


    }
}
