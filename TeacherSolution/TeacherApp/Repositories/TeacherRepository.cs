using TeacherApp.Entities;
namespace TeacherApp.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public List<Teacher> GetAll()
        {
            using (var context = new TeacherContext())
            {
                var teachers = from t in context.teachers
                               select t;
                return teachers.ToList<Teacher>();
            }
        }
        public List<Teacher> GetByID(int id)
        {
            using (var context = new TeacherContext())
            {
                var ts = from t in context.teachers
                         where t.id == id
                         select t;
                return ts.ToList<Teacher>();
            }
        }
        public Boolean DeleteById(int id)
        {
            using (var context = new TeacherContext())
            {
                var ts = from t in context.teachers
                         where t.id == id
                         select t;
                context.teachers.RemoveRange(ts);
                context.SaveChanges();
                return true;
            }

        }
        public Boolean Update(Teacher teacher)
        {
            using(var context = new TeacherContext()) { 

        }
    }
}
