using TeacherApp.Entities;
using TeacherApp.Repositories;
namespace TeacherApp.Services
{
    public class TeacherService : ITeacherService
    {
        ITeacherRepository repository = new TeacherRepository();
        public List<Teacher> GetAll()
        {

            return repository.GetAll();
        }
        public List<Teacher> GetByID(int id)
        {
            return repository.GetByID(id);
        }
        public Boolean DeleteById(int id)
        {
            return repository.DeleteById(id);
        }
    }
}
