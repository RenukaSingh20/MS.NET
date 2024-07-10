using TeacherApp.Entities;
namespace TeacherApp.Repositories
{
    public interface ITeacherRepository
    {
         List<Teacher> GetAll();
        List<Teacher> GetByID(int id);
        Boolean DeleteById(int id);
        Boolean Update(int id,Teacher teacher);
    }
}
