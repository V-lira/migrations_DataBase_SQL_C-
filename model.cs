namespace Welcome
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        //navigaion
        public Department Department { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}