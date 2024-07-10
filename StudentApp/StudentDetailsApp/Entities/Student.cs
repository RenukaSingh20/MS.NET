namespace StudentDetailsApp.Entities
{
    public class Student
    {
        public int Student_Id { get; set; }
        public string Student_name { get; set; }
        public string Student_EmailId { get; set; }
        public string Mobile_Number  { get; set; }
        public string Student_Address { get; set; }
        public string Admission_date { get; set; }
        public int Fees { get; set; }
        public Boolean Status { get; set; }

        public override string ToString()
        {
            return "Id:" + this.Student_Id + "Name:" + this.Student_name + "Student_EmailId"+this.Student_EmailId+"MobileNo:" + this.Mobile_Number +
                "Address :" + this.Student_Address + "AdmissionDate:" + this.Admission_date +
                "Fees :" + this.Fees + "Status:" + this.Status;
        }

    }
}
