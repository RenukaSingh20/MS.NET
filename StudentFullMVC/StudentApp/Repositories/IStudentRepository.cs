using StudentApp.Models;
namespace StudentApp.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
    }
}
