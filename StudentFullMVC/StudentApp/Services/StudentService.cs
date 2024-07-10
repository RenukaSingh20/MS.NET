using StudentApp.Models;
using StudentApp.Repositories;

namespace StudentApp.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> GetAll()
        {
            return StudentRepository.GetAll();
        }
    }
}
