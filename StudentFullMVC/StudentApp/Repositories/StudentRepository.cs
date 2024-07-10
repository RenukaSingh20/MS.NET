using StudentApp.Models;
using System.Linq;
namespace StudentApp.Repositories
{
    public class StudentRepository
    {
        public static List<Student> GetAll()
        {
            using (var context = new StudentCollectionContext())
            {
                var std = from s in context.dbcontext
                          select s;
                return std.ToList<Student>();
            }
        }
    }
}


