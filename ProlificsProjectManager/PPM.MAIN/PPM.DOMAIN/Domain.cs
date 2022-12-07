using System;
using ProlificsProjectManager.PPM.MAIN.PPM.MODEL;

namespace ProlificsProjectManager.PPM.MAIN.PPM.DOMAIN
{
    public class ProjectManager
    {
        public List<Project>Projects = new List<Project>();

        public void AddingProjects(Project project)
        {
            Projects.Add(project);
        }

        public void displayProject(Project project)
        {
            Console.WriteLine("Name of the project - " + project.ProjectName + "\n project Id - " + project.id + "\n Start date of project -" + project.Startdate + "\n End date of project -" + project.Enddate);
        }

        public void displayAllProjects()
        {
            foreach (var i in Projects)
            {
                displayProject(i);
            }
        }

        public void ShowProject(int pid)
        {
            foreach (Project i in Projects)
            {
                if (i.id == pid)
                {
                    Console.WriteLine(" Name of the project - " + i.ProjectName + " \n project Id - " + i.id + " \n Start date of project -" + i.Startdate + "\n End date of project -" + i.Enddate);
                }
                else
                {
                    Console.WriteLine("Id not found");
                }
            }
        }
        public void SearchProject(string search)
        {
            var match = Projects.Where(c => c.ProjectName.Contains(search));
            foreach(var i in match)
            {
                Console.WriteLine("Name of the project - " + i.ProjectName + "\n project Id - " + i.id + "\n Start date of project -" + i.Startdate + "\n End date of project -" + i.Enddate);
            }
        }
    }

    public class EmployeeManager
    {
        public List<Employee> empList = new List<Employee>();

        public void AddEmp(Employee emp)
        {
            empList.Add(emp);
        }

        public void displayEmp(Employee employee)
        {
            Console.WriteLine("Employee Id -" + employee.EmployeeID + "\n Employee first name -" + employee.firstName + "\n Employee last name -" + employee.lastName + "\n Employee email id -" + employee.email + "\n Employee mobile number  -" + employee.mobile + "\n Employee address -" + "\n  Role ID -" + employee.roleid + "\n Role Name -" + employee.roleName);
        }

        public void ShowEmp() 
        {
            foreach (var i in empList)
            {
                displayEmp(i);
            }
        }

        public void ShowEmployee(int eid)
        {
            foreach (Employee i in empList)
            {

                if (i.EmployeeID == eid)
                {
                    Console.WriteLine(" Name of the Employee - " + i.firstName + " " + i.lastName + "\n Employee Id - " + i.EmployeeID);
                }
                else
                {
                    Console.WriteLine("Id not found");
                }
            }
        }
    }


    public class RoleManager
    {
        public List<Role> RoleList = new List<Role>();

        public void RoleAdd(Role role)
        {
            RoleList.Add(role);
        } 

        public void dispalyRole()
        {
            foreach (var i in RoleList)
            {
                Console.WriteLine("Name of the Role -" + i.RoleName+ "\n Role Id - " + i.RoleId);
            }
        }
    }
}
