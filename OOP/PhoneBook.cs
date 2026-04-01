using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct PhoneBook
    {
        long[] Numbers;

        string[] Names;

        int size;

        public int Size
        {
            get { return size; }
            private set { size = value < 10 ? 10 : value; }
        }

        /// constructor chaning => calling one constructor from another constructor in the same struct
        public PhoneBook() : this(0) // calling the constructor with one parameter and passing 0 as the argument to it
        {
            //size = default; // 0
            //Numbers = default; // null
            //Names = default; // null
        }

        public PhoneBook(int _size)
        {
            Size = _size; // will call the setter of the Size property to check the value and set it to 10 if it's less than 10
            Numbers = new long[Size];
            Names = new string[Size];
        }


        ///method to add a new contact to the phone book
        ///takes a name and a number and a postion as parameters and adds them to the phone book


        ///method to get contact by name return number
        ///takes name as parameter and return number

        ///method to set contact by name
        ///takes name and number as parameters and update the number of the contact with the given name
    }
}
