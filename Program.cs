using System;
using System.Linq;
namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new HospitalContext();
            Console.WriteLine("Succes!");
            if (!context.Departments.Any())
            {
                var department = new Department { DepartmentName = "psychology" };
                context.Departments.Add(department);
                context.SaveChanges();
                var doctor = new Doctor
                {
                    FullName = "Familyyy Fame DOfDoctors",
                    Salary = 532432,
                    DepartmentId = department.Id
                };
                context.Doctors.Add(doctor);
                context.SaveChanges();
            }

            Console.WriteLine($"Count -> departments: {context.Departments.Count()}");
            Console.WriteLine($"Cout of doctors: {context.Doctors.Count()}");
        }
    }
}