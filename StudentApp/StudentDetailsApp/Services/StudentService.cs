using StudentDetailsApp.Entities;
using StudentDetailsApp.Repositories;
namespace StudentDetailsApp.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> GetAllStudents()
        {

            return StudentRepository.GetAllStudents();
        }
        public Student AddNewStudent(Student student)
        {

            return StudentRepository.AddNewStudent(student);
        }
        public List<Student> GetStudentById(int id)
        {
            return StudentRepository.GetStudentById(id);
        }
    }
}
