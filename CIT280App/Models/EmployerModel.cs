using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIT280App.Models
{
    public class EmployerModel : UserModel
    {
        public string JobID { get; set; }
       
        public virtual IEnumerable<JobsModel> JobsModel { get; set; }
    }
}  