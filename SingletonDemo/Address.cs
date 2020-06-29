using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    [System.Serializable]
    public class Address
    {
        string addr;

        public Address(string address)
        {
            addr = address;
        }

        public string ToString()
        {
            return addr;
        }
    }
}
