using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIT280App.Models
{
    public class EmployerModel : UserModel
    {
        public string BuisnessName { get; set; }
        public string BuisnessType { get; set; }
    }
}  