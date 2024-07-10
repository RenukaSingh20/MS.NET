using StudentDetailsApp.Entities;
namespace StudentDetailsApp.Services
{
    public interface IStudentService
    {
        public List<Student> GetAllStudents();
        public Student AddNewStudent(Student student);
        public List<Student> GetStudentById(int id);
        
    }
}
