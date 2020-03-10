using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIT280App.Models;


namespace CIT280App.DataLayer
{
    public class DbSeedInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DbSeedContext>
    {
        protected override void Seed(DbSeedContext context)
        {
            var user = new List<UserModel>
            {
                new UserModel{ ID=0, Role=Roles.Admin, FirstName="Joseph", LastName="Jippy", City="Pontiac", State="MI", Email="theJips@yahoo.com"   },
                new UserModel{ ID=1, Role=Roles.Student, FirstName="Kyle", LastName="Kilimanjaro", City="Frankfort", State="MI", Email="Imamountain@gmail.com", Phone=6165373392 },
                new UserModel{ ID=2, Role=Roles.Employer, FirstName="Frylock", LastName="Fries", City="Ypsilanti", State="MI", Email="BoxofFries@outlook.com", Description="Scientist", Reviews="untrusworthy"   },
                new UserModel{ ID=3, Role=Roles.Employer, FirstName="Arman", LastName="Gardiner", City="Kalkaska", State="MI", Email="gardinman@cmu.edu", Phone=2833820432, Description="Loves to Garden", Reviews="Great Gardener"   },
                new UserModel{ ID=4, Role=Roles.Student, FirstName="Yvie", LastName="Devlin", City="Ypsilanti", State="MI", Email="devyvie@emu.edu",Description=" I am a great worker", Reviews="this person is not a good worker", Phone=8231839382   },
                new UserModel{ ID=5, Role=Roles.Employer, FirstName="Corinne", LastName="Sharples", City="Lawrence", State="KS", Email="SharpyBoy@farmersonly.com"   },
                new UserModel{ ID=6, Role=Roles.Student, FirstName="Tom", LastName="Farrer", City="Traverse City", State="MI", Email="farrert@nmc.edu", Reviews="smells like coffee"  },
                new UserModel{ ID=7, Role=Roles.Student, FirstName="Mitch", LastName="McDuck", City="Coolsville", State="MI", Email="mmquack@nmc.edu", Phone=2317771777, Reviews="fan of anti-disestablishmentarianism"   },
                new UserModel{ ID=8, Role=Roles.Admin, FirstName="Alibaster", LastName="Crabs", City="Buckley", State="MI", Email="acrabs46@nmc.edu"}
            };
            var student = new List<StudentModel>
            {
                new StudentModel{ StudentID=1, Major="Business", School="CMU", YearInSchool=3, JobID=1},
                new StudentModel{ StudentID=4, Major="Child Education", School="EMU ", YearInSchool=1, JobID=2},
                new StudentModel{ StudentID=6, Major="Agriculture", School="NMC", YearInSchool=7},
                new StudentModel{ StudentID=7, Major="Communication", School="NMC", YearInSchool=2},
            };
            var employer = new List<EmployerModel>
            {
                new EmployerModel{EmployerID = 2 , JobID = 1},
                new EmployerModel{EmployerID = 2 , JobID = 3},
                new EmployerModel{EmployerID = 3 , JobID = 2, },
                new EmployerModel{EmployerID = 5 , JobID = 4}
            };
            var job = new List<JobsModel>
            {
                new JobsModel{ID = 1, Name="Widget Smashing", Description="Grab a widget and smash it", City="Traverse City", State="MI", RequiredSkills="abiltiy to lift 50 pounds", Pay=25, IsComplete=true, EmployerId=2, StudentId=1},
                new JobsModel{ID = 2, Name="Printer Problems", Description="Help Hooking up printer.", City="Frankfort", State="MI", RequiredSkills="2 years experience of setting up printers", Pay=1, IsComplete=false, EmployerId=2},
                new JobsModel{ID = 3, Name="Test Subject", Description="Try my pill", City="Ypsilanti", State="MI", RequiredSkills="Quiet", Pay=100, IsComplete=true, EmployerId=2, StudentId=4},
                new JobsModel{ID = 4, Name="Website Design", Description="Design my Grandma's website", City="Traverse City", State="MI", RequiredSkills="HTMl and CSS basics", Pay=0, IsComplete=false, EmployerId=5}

            };
        }
    }
}