using EFCore.Contexts;
using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main()
        {
            #region How To Migrate
            //to add db to sql server:

            ///1.Install-Package "Microsoft.EntityFrameworkCore.SqlServer"
            ///2.create Compnydbcontext that inhert DbContext
            ///3.override OnConfiguring and set db conection string
            ///4.add dbset<> for class (Models) that want to be tables
            ///5.install Package Microsoft.EntityFrameworkCore.Tools
            ///6.Add-Migration "InitialCreate"
            ///7.Update-Database
            #endregion


            #region CRUD Operations [create, read, update, delete]
            //unmanaged code
            //CompanyDbContext db = new CompanyDbContext();
            //try
            //{
            //    //crud operations
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    db.Dispose(); //close connection
            //}

            //using (CompanyDbContext db2 = new CompanyDbContext()) //managed code
            //{
            //    //crud operations
            //}

            //using CompanyDbContext db = new CompanyDbContext(); //managed code
            //crud operations
            //code
            //crud operations

            //Employee emp = new Employee()
            //{
            //    Name = "Ahmed",
            //    Salary = 5000,
            //    Age = 30,
            //};

            //Department dept = new Department { Name = "HR" };



            #region Create
            //db.Employees.Add(emp);
            //db.Add(emp);
            //db.Set<Department>().Add(dept);
            //db.Entry(emp).State = EntityState.Added;
            //db.SaveChanges();

            //Console.WriteLine(db.Entry(emp).State);
            //db.Employees.Add(emp);
            //Console.WriteLine(db.Entry(emp).State);
            //db.SaveChanges();
            //Console.WriteLine(db.Entry(emp).State);
            #endregion

            #region Read
            #region Multi elements
            //var result = (from emp in db.Employees
            //             where emp.Id == 1
            //             select emp); //linq => select * from employees where id = 1
            //var result2 = db.Employees.ToList().Where(emp => emp.Id == 1); //linq => select * from employees where id = 1

            //foreach (var emp in result)
            //{
            //    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Age: {emp.Age}, Email: {emp.Email}");
            //}
            #endregion
            #region Single elements
            //var Emp = (from emp in db.Employees
            //              where emp.Id == 1
            //              select emp)
            //              .First(); //top(1) => select top(1) * from employees where id = 1
            //                        //.FirstOrDefault(); //top(1) => select top(1) * from employees where id = 1
            //                        //.Single(); //top(2) => select top(2) * from employees where id = 1
            //                        //.SingleOrDefault(); //top(2) => select top(2) * from employees where id = 1
            //Console.WriteLine($"Id: {Emp.Id}, Name: {Emp.Name}, Salary: {Emp.Salary}, Age: {Emp.Age}, Email: {Emp.Email}");

            //var Emp = db.Employees.Find(1); //select * from employees where id = 1
            #endregion
            #region Tracking Vs NoTracking
            //db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //var Emp = (from emp in db.Employees
            //           where emp.Id == 1
            //           select emp)
            //           //.AsNoTracking()
            //           .AsTracking()
            //              .First();
            //Console.WriteLine(db.Entry(Emp).State);
            #endregion
            #endregion

            #region Update
            //var EMP = db.Employees.Where(emp => emp.Id == 1).FirstOrDefault();
            //if (EMP != null)
            //{
            //    EMP.Name = "Ahmed Updated";
            //    EMP.Salary = 6000;
            //    db.Employees.Update(EMP);
            //    Console.WriteLine(db.Entry(EMP).State);
            //    db.SaveChanges();
            //}
            #endregion

            #region delete
            //var EMP = db.Employees.Where(emp => emp.Id == 1).FirstOrDefault();
            //if (EMP != null)
            //{
            //    Console.WriteLine(db.Entry(EMP).State);
            //    db.Employees.Remove(EMP);
            //    Console.WriteLine(db.Entry(EMP).State);
            //    db.SaveChanges();
            //    Console.WriteLine(db.Entry(EMP).State);
            //}
            #endregion
            #endregion

            #region Mapping RealtionShip
            ///pk => fk
            ///3. how to implment in code
            ///     3.1 fk property [class name + pk name]
            ///     3.2 Navigational property [class name]
            ///     by defaulty 
            #endregion

            #region Mapping Inhertince
            using InheritanceDbContext dbContext = new InheritanceDbContext();
            Person person = new Person()
            {
                Name = "AliTPC",
                Age = 20
            };
            FullTime ftEmployee = new FullTime()
            {
                Name = "AhmedTPC",
                Age = 30,
                Salary = 5000,
                HiringDate = DateOnly.FromDateTime(DateTime.Now)
            };

            PartTime ptEmployee = new PartTime()
            {
                Name = "MohamedTPC",
                Age = 25,
                HourRate = 50,
                HoursCount = 20
            };

            #region TPH
            #region TwoDbset
            //dbContext.FullTimePerson.Add(ftEmployee);
            //dbContext.PartTimePerson.Add(ptEmployee);
            //dbContext.SaveChanges();

            //var FTPerson = from p in dbContext.FullTimePerson
            //               select p;

            //foreach (var item in FTPerson)
            //    Console.WriteLine($"FullTime Employee:{item.Name}, Salary: {item.Salary}");

            //var PTPerson = from p in dbContext.PartTimePerson
            //               select p;

            //foreach (var item in PTPerson)
            //    Console.WriteLine($"PartTime Employee:{item.Name}, HourRate: {item.HourRate}, HoursCount: {item.HoursCount}");
            #endregion
            #region OneDbset
            //dbContext.Persons.Add(person);
            //dbContext.Persons.Add(ftEmployee);
            //dbContext.Persons.Add(ptEmployee);
            //dbContext.SaveChanges();

            //var persons = from p in dbContext.Persons
            //              select p;

            //Console.WriteLine("*****************Persons******************");
            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"FullTime Employee:{item.Name}, Type: {item.GetType().Name}");
            //}

            //var fullTimePersons = from p in dbContext.Persons.OfType<FullTime>()
            //                      select p;

            //Console.WriteLine("*****************fulltime******************");
            //foreach (var item in fullTimePersons)
            //{
            //    Console.WriteLine($"FullTime Employee:{item.Name}, Salary: {item.Salary}");
            //}


            //var parttimeemployees = from Person in dbContext.Persons.OfType<PartTime>()
            //                        select Person;
            //Console.WriteLine("*****************parttime******************");
            //foreach (var item in parttimeemployees)
            //{
            //    Console.WriteLine($"FullTime Employee:{item.Name}, Hour rate: {item.HourRate}");
            //}


            //var Personsonly = from Person in dbContext.Persons.OfType<Person>()
            //                        select Person;
            //Console.WriteLine("*****************Personsonly******************");
            //foreach (var item in Personsonly)
            //{
            //    Console.WriteLine($"FullTime Employee:{item.Name}");
            //}
            #endregion
            #endregion

            #region TPT
            //dbContext.FullTimePersons.Add(ftEmployee);
            //dbContext.PartTimePersons.Add(ptEmployee);
            //dbContext.Persons.Add(person);
            //dbContext.Persons.Add(ftEmployee);
            //dbContext.Persons.Add(ptEmployee);
            //dbContext.SaveChanges();


            //var persons = from p in dbContext.Persons
            //              select p;

            //Console.WriteLine("*****************Persons******************");
            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"FullTime Employee:{item.Name}, Type: {item.GetType().Name}");
            //}


            //var fullTimePersons = from p in dbContext.FullTimePersons
            //                      select p;

            //Console.WriteLine("*****************fulltime******************");
            //foreach (var item in fullTimePersons)
            //{
            //    Console.WriteLine($"FullTime Employee:{item.Name}, Salary: {item.Salary}");
            //}

            #endregion

            #region TPC
            //dbContext.FullTimePersons.Add(ftEmployee);
            ////dbContext.FullTimePersons.Add(person); not valid
            //dbContext.PartTimePersons.Add(ptEmployee);
            ////dbContext.PartTimePersons.Add(person); not valid
            //dbContext.SaveChanges();

            //var fullTimePersons = from p in dbContext.FullTimePersons
            //                      select p;

            //Console.WriteLine("*****************fulltime******************");
            //foreach (var item in fullTimePersons)
            //{
            //    Console.WriteLine($"FullTime Employee:{item.Name}, Salary: {item.Salary}");
            //}

            #endregion

            #endregion
        }
    }
}
