using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeacherApp.Services;
using TeacherApp.Repositories;

namespace TeacherApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private ITeacherService _TeacherService;
        public TeacherController(ITeacherService TeacherService)
        {
            this._TeacherService = TeacherService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_TeacherService.GetAll());
        }
        [HttpGet("getbyid/{id}")]
        public IActionResult GetByID(int id)
        {
            return Ok(_TeacherService.GetByID(id));
        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById(int id)
        {
            return Ok(_TeacherService.DeleteById(id));
        }
    }
}
