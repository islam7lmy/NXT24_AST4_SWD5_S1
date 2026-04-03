using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    internal struct PhoneBook
    {
        long[] Numbers;

        string[] Names;

        int count; /// field to store the number of contacts in the phone book

        int size; /// field to store Capacity of the phone book

        public int Size
        {
            get { return size; }
            private set { size = value < 3 ? 3 : value; }
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
        public void AddContact(string Name, long Number/*, int position*/)
        {
            /*if (position >= 0 && position < size)
            {
                Names[position] = Name;
                Numbers[position] = Number;
            }*/

            //for (int i = 0; i < size; i++)
            //{
            //    if (Names[i] is null)
            //    {
            //        Names[i] = Name;
            //        Numbers[i] = Number;
            //        break;
            //    }
            //}

            //int postion = Array.IndexOf(Names, null); // find the first index of the null value in the Names array
            //if (postion >= 0)
            //{
            //    Names[postion] = Name;
            //    Numbers[postion] = Number;
            //}

            if (count == Size)
            {
                ///apply Resize to the arrays to increase their capacity
                Resize(size + 1);
            }

            if (count < size)
            {
                Names[count] = Name;
                Numbers[count] = Number;
                count++;
            }

        }

        /// method to remove contact by name
        public void RemoveContact(string Name)
        {
            int index = Array.IndexOf(Names, Name);
            if (index >= 0)
            {
                for (int i = index; i < count - 1; i++) //count => 3 , i => 2
                {
                    Names[i] = Names[i + 1]; //2 + 1 => out of range 
                    Numbers[i] = Numbers[i + 1];
                }
                count--;
                Resize(size - 1);
            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
        }


        #region indexer to get contact by name return number and to set contact by name
        ///method to get contact by name return number
        ///takes name as parameter and return number
        public long GetContactByName(string Name)
        {
            int index = Array.IndexOf(Names, Name);
            if (index >= 0)
            {
                return Numbers[index];
            }
            else
            {
                return -1; // return -1 to indicate that the contact was not found
            }
        }

        ///method to set contact by name
        ///takes name and number as parameters and update the number of the contact with the given name
        public void SetContactByName(string Name, long Number)
        {
            int index = Array.IndexOf(Names, Name);
            if (index >= 0)
            {
                Numbers[index] = Number;
            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
        }


        /// special property called indexer to get contact by name return number
        public long this[string Name]
        {
            get 
            {
                int index = Array.IndexOf(Names, Name);
                if (index >= 0)
                {
                    return Numbers[index];
                }
                else
                {
                    return -1; // return -1 to indicate that the contact was not found
                }
            }
            set
            {
                int index = Array.IndexOf(Names, Name);
                if (index >= 0)
                {
                    Numbers[index] = value;
                }
                else
                {
                    Console.WriteLine("Contact Not Found");
                }
            }
        }
        #endregion

        #region Indexer to get contact by index return name and number
        public string GetContactByIndex(int index)
        {
            if (index >= 0 && index < count)
            {
                return $"{Names[index]} : {Numbers[index]}";
            }
            else
            {
                return "Invalid Index";
            }
        }

        /// special property called indexer to get contact by index return name and number
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return $"{Names[index]} : {Numbers[index]}";
                }
                else
                {
                    return "Invalid Index";
                }
            }
        }
        #endregion

        private void Resize(int newsize)
        {
            if (newsize != size)
            {
                long[] newnumbers = new long[newsize];
                string[] newnames = new string[newsize];

                if (newsize > size)
                {
                    Array.Copy(Numbers, newnumbers, size);
                    Array.Copy(Names, newnames, size);

                    //Numbers.CopyTo(newnumbers, 0);
                    //Names.CopyTo(newnames, 0);
                }
                else if (newsize < size)
                {
                    if (newsize >= count)
                    {
                        Array.Copy(Numbers, newnumbers, newsize);
                        Array.Copy(Names, newnames, newsize);
                        //for (int i = 0; i < newsize; i++)
                        //{
                        //    newnumbers[i] = Numbers[i];
                        //    newnames[i] = Names[i];
                        //}
                    }
                    else
                    {
                        Console.WriteLine("Can not modify size");
                        return;
                    }
                }

                Numbers = newnumbers;
                Names = newnames;

                size = newsize;
            }
        }
    }
}
