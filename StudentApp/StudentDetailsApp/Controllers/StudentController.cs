using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetailsApp.Services;
using StudentDetailsApp.Entities;

namespace StudentDetailsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet]
        public IActionResult AddNewStudent(Student student)
        {
            return Ok(_studentService.AddNewStudent);
        }
        [HttpGet("getbyId{id}")]
        public IActionResult GetStudentById(int id)
        {
            return Ok(_studentService.GetStudentById(id));
        }
    }
}
