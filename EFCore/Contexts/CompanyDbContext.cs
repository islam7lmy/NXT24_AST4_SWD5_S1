using EFCore.Configurations;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = ISLAM7LMYLAPVM\\ISLAM7LMY; Intial Catalog = NXT24.EFMyCompany; Integrated Security = true");
            //optionsBuilder.UseSqlServer("Data Source = ISLAM7LMYLAPVM\\ISLAM7LMY; Intial Catalog = NXT24.EFMyCompany; User Id = sa; Password = 1234567");
            //optionsBuilder.UseSqlServer("server = ISLAM7LMYLAPVM\\ISLAM7LMY; Database = NXT24.EFMyCompany; User Id = sa; Password = 1234567");
            optionsBuilder.UseSqlServer("Data Source=ISLAM7LMYLAPVM\\ISLAM7LMY;Initial Catalog=NXT24.EFMyCompany;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // when inhert from dbcontext contain dbsets as scurity modual has 7 dbsets
            // inhert IdentityDbContext
            //base.OnModelCreating(modelBuilder);

            #region 3. Fluent API
            #region ways To access Property
            //modelBuilder.Entity<Employee>()
            //   .Property("Name")
            //   .HasDefaultValue("No Name");

            //modelBuilder.Entity<Employee>()
            //   .Property(nameof(Employee.Name))
            //   .HasDefaultValue("No Name");

            //modelBuilder.Entity<Employee>()
            //   .Property(e => e.Name)
            //   .HasDefaultValue("No Name");
            #endregion

            #region Shadow Property
            //modelBuilder.Entity<Employee>()
            //    .Property<string>("Address")
            //    .HasColumnType("nvarchar(100)");
            #endregion

            #region Mapping To Class
            //modelBuilder.Entity<Department>()
            //    .ToTable("DepartmentsInfo", "dbo")
            //    .HasKey(d => d.DeptId);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //modelBuilder.Entity<Department>()
            //    .Property(d => d.Name)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("nvarchar(50)")
            //    .IsRequired();

            //modelBuilder.Entity<Department>()
            //    .Property(d=> d.CreationDate)
            //    .HasColumnType("date")
            //    .HasComputedColumnSql("GETDATE()");

            ///efcore 3.1 new feature
            //modelBuilder.Entity<Department>(d =>
            //{
            //    d.ToTable("DepartmentsInfo", "dbo")
            //    .HasKey(d => d.DeptId);

            //    d.Property(d => d.DeptId)
            //    .UseIdentityColumn(10, 10);

            //    d.Property(d => d.Name)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("nvarchar(50)")
            //    .IsRequired();

            //    d.Property(d => d.CreationDate)
            //    .HasColumnType("date")
            //    .HasComputedColumnSql("GETDATE()");

            //});
            #endregion

            #endregion

            #region 4. ConfigurationClass Per Entity => Organized 3rd way
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfigurations());
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #endregion
        }

        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
