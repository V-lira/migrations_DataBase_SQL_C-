using Microsoft.EntityFrameworkCore;

namespace Welcome
{
    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PC\SQLEXPRESS;Database=hospital;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one-to-many
            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Department)
                .WithMany(d => d.Doctors)
                .HasForeignKey(d => d.DepartmentId);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "surgery" },
                new Department { Id = 2, DepartmentName = "herapy" },
                new Department { Id = 3, DepartmentName = "pediatrics" },
                new Department { Id = 4, DepartmentName = "nevrology" },
                new Department { Id = 5, DepartmentName = "psychology" }
            );
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, FullName = "Nameness Name Namenneess", Salary = 555555, DepartmentId = 1 },
                new Doctor { Id = 2, FullName = "Fameless Fame Famelllesss", Salary = 58436534, DepartmentId = 2 },
                new Doctor { Id = 3, FullName = "FullNameless FullName FullNameless", Salary = 5321313, DepartmentId = 3 },
                new Doctor { Id = 4, FullName = "Unbeliveable Believe Incredibility", Salary = 76887635, DepartmentId = 1 },
                new Doctor { Id = 5, FullName = "Loveless Love Lonely", Salary = 87687865, DepartmentId = 5 }
            );
        }
    }
    }