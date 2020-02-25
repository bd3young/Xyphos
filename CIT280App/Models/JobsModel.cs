using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIT280App.Models
{
    public class JobsModel
    {
        // this is a test
        // this is test 2
        public string JobID { get; set; }
        public bool IsComplete { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RequiredSkills { get; set; }
        public virtual string PhotoPath { get; set; }
        public int Pay { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}