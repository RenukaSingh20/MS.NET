using Microsoft.AspNetCore.Mvc;
using StudentDetailsApp.Entities;
using StudentDetailsApp.Repositories;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
namespace StudentDetailsApp.Repositories
{
    public class StudentRepository
    {
        public static List<Student> GetAllStudents()
        {
            using (var context = new Studentcontext())
            {
                var student = from std in context.dbcontext
                              select std;
                return student.ToList<Student>();

            }
        }
        public static Student AddNewStudent(Student stdt)
        {
            using (var context = new Studentcontext())
            {
                var std = context.dbcontext.Add(stdt);
                context.SaveChanges();
                return stdt;
            }
        }
        public static List<Student> GetStudentById(int id)
        {
            using (var context = new Studentcontext())
            {
                var stds = from studnt in context.dbcontext
                           where studnt.Student_Id == id
                           select studnt;
                return stds.ToList<Student>();

            }
        }
    }
}
        
    
