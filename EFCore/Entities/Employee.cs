using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    #region Properties Mapping
    /// Ef Core Suppotes 4 ways for mapping
    /// 1. by Convention (Default)
    /// 2. Data Annotations [set of attributes used for valdation]
    /// 3. Fluent API (set of methods to do congfigurations)
    /// 4. ConfigurationClass Per Entity => Organized 3rd way 


    #region 1. by Convention (Default Bhavior)
    //internal class Employee
    //{
    //    public int Id { get; set; } //primary key by convention identity(1,1) int not allow null
    //    public string? Name { get; set; } //nvarchar(max) allow null
    //    public double Salary { get; set; } // float not allow null
    //    public int? Age { get; set; } // int allow null
    //}
    #endregion

    #region 2. Data Annotations
    //[Table("EmployeesInfo" , Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; } //primary key by convention identity(1,1) int not allow null

    //    [Required]
    //    [Column(TypeName = DBTypes.Nvarchar)] //[Column(TypeName = "varchar")]
    //    [MaxLength(100)]
    //    [StringLength(50,MinimumLength = 10)]
    //    public string? Name { get; set; } //nvarchar(max) allow null

    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; } // float not allow null

    //    [Range(22,60)]
    //    public int? Age { get; set; } // int allow null

    //    [DataType(DataType.EmailAddress)]
    //    [EmailAddress]
    //    public string Email { get; set; }

    //    [NotMapped]
    //    public int test { get; set; }

    //    public double NetSalary
    //    {
    //        get
    //        {
    //            return Salary - (Salary * 0.1);
    //        }
    //    }
    //}
    #endregion

    #region 3. Fluent API
    internal class Employee
    {
        public int Id { get; set; } //primary key by convention identity(1,1) int not allow null
        public string? Name { get; set; } //nvarchar(max) allow null
        public double Salary { get; set; } // float not allow null
        public int? Age { get; set; } // int allow null
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public double NetSalary => Salary * .9;
    }
    #endregion

    #endregion

    public static class DBTypes
    {
        public const string Varchar = "varchar";
        public const string Nvarchar = "nvarchar";
        public const string Int = "int";
        public const string Float = "float";
    }
}
