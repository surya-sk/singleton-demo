using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    [System.Serializable]
    public class Person : Settings
    {
        string fName;
        string lName;
        Address addr;

        public Person(string firstName, string lastName, Address address)
        {
            fName = firstName;
            lName = lastName;
            addr = address;
        }

        public string ToString()
        {
            return fName + " " + lName + " " + addr.ToString();
        }
    }
}
