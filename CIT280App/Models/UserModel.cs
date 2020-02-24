using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIT280App.Models
{
    public enum Role
    {
        Admin,
        Employer,
        Student
    }
    public class UserModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual int Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        public string Reviews { get; set; }
        public Role Role { get; set; }

    }
}