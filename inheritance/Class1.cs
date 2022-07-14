using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Person
    {
        private string _name;
        private string _address;
        private string _phone;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }

        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

         private string _GetPersonData()
        {
            return _name+";"+ _address+";"+ _phone; 
        }

        public string GetPersonData()
        {
            return _GetPersonData().Replace( "; ","\n");
        }

        public void PrintData()
        {
            Console.WriteLine(GetPersonData());
        }
       
       
    }
}

