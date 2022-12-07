using System;

namespace ProlificsProjectManager.PPM.MAIN.PPM.MODEL
{
    public class Project
    {
        public string ProjectName {get; set;}
        public string Startdate {get; set;}
        public string Enddate {get; set;}
        public int? id {get; set;}

        public Project (string projectname, string startdate, string enddate, int Id )
        {
            this.ProjectName = projectname;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.id = Id;
        }
        public Project()
        {

        }
    }

    public class Employee
    {
        public int EmployeeID {get; set;}
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string email {get; set;}
        public string mobile {get; set;}
        public string address {get; set;}
        public int roleid {get; set;}
        public string roleName { get; set; }

        public Employee(int employeeid, string FirstName, string LastName, string Email, string Mobile, string Address, int RoleID, string Rolename)
        {
            EmployeeID = employeeid;  
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            mobile = Mobile;
            address = Address;
            roleid = RoleID;
            roleName = Rolename;
        }

        public Employee()
        {

        }
    }


    public class Role
    {
        public string RoleName {get; set;}
        public int RoleId {get; set;}

        public Role(int roleid, string roleName)
        {
            RoleName = roleName;
            RoleId = roleid;
        }
    }
}



