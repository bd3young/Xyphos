using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIT280App.Models
{
    public class JobsModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }       
        public string Description { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string RequiredSkills { get; set; }
        public virtual string Photo { get; set; }
        public int Pay { get; set; }        
        public bool IsComplete { get; set; }

        public virtual UserModel User { get; set; }
        public virtual StudentModel Student { get; set; }
        public virtual EmployerModel Employer { get; set; }
    }
}