using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {


        public int Id { get; set; }

        public int FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public static implicit operator Customer(Customer v)
        {
            throw new NotImplementedException();
        }
    }
}
