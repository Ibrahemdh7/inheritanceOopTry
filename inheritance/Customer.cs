using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Customer:Person
    {
        private string _ShipMentAddress;
        public string ShipMentAddress
        {
            get { return _ShipMentAddress; }
            set { _ShipMentAddress = value; }
        }

    }
}
