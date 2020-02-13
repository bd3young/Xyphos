using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIT280App.Models
{
    public class StudentModel:UserModel
    {
        public string SutdentID { get; set; }
        public string Major { get; set; }
        public string School { get; set; }
        public string YearInSchool { get; set; }
        public string JobID { get; set; }
        public string PreviousJobs { get; set; }
        public virtual IEnumerable<JobsModel> JobsModel { get; set; }
    }
}