using System;
using System.Collections.Generic;

namespace DBfirst.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? PhoneNo { get; set; }
        public string Email { get; set; } = null!;
        public string Department { get; set; } = null!;


    }
}
