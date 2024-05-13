using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HKO_lesson05.Models
{
    public class HKOCustomer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address  { get; set; }
        public int YearOfBirth  { get; set; }
    }
}