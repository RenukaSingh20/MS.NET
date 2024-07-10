using TeacherApp.Entities;

namespace TeacherApp.Services
{
    public interface ITeacherService
    {
        List<Teacher> GetAll();
        List<Teacher> GetByID(int id);
        Boolean DeleteById(int id); 
    }
}
