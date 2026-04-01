using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        //public int Id;
        public int Id { get; set; }

        #region Encapsulation => Seperates The Data Defintion (Attribute) From Its Use (GetterSetter Or Property)
        /// read value saved in it
        /// can save only 20 characters in it 
        /// if you try to save more than 20 characters 
        /// it will substring the value to 20 characters and save it
        private string Name;
        public string GetName()
        {
            return Name;
        }

        public void SetName(string Value)
        {
            Name = Value.Length <= 20 ? Value : Value.Substring(0, 20);
        }
        #endregion

        #region 1. Full Property
        /// Minimum Salary = 3000 if you try to save less than 3000 it will save 3000
        private decimal salary; //field to save the salary value
        //public decimal GetSalary()
        //{
        //    return salary;
        //}
        //public void SetSalary(decimal Value)
        //{
        //    salary = Value < 3000 ? 3000 : Value;
        //}
        public decimal Salary // property to control access to the salary field
        {
            get { return salary; }
            set { salary = value < 3000 ? 3000 : value; }
        }
        #endregion

        #region 2. Autmatic property
        /// only set data from the constructor and can't change it after that
        //private int age;
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        /// CLR will Generate The Backing Field For The Automatic Property [Hidden Private Attribute]
        public int Age { get; private set; }


        /// 20% Deduction From The Salary 
        /// any change in the salary will affect the deduction value 
        /// because it's calculated based on the salary value
        ///public decimal Deduction;
        public decimal Deduction { get { return Salary * 0.2M; } }
        #endregion

        public Employee(int id, string name, decimal _salary, int _age)
        {
            Id = id;
            SetName(name);
            Salary = _salary;
            Age = _age;
        }


    }
}
