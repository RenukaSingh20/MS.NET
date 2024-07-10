namespace TeacherApp.Entities
{
    public class Teacher
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int salary { get; set; }
        public string status { get; set; }

        public override string ToString()
        {
            return "id:" + this.id + "name:" + this.name + "email:" + this.email + "phone:"
                + this.phone + "salary:" + this.salary + "status:" + this.status;
        }

    }
}
