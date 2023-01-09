using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.List
{
    public class Staff
    {
        List<Person> Employees { get; set; }
        public Staff()
        {
            FillUpEmployees();
        }
        public void FillUpEmployees() { 
            Employees.Add(new Person(1, "Frank", "Castle"));
            Employees.Add(new Person(2, "Peter", "Parker"));
            Employees.Add(new Person(3, "Bruce", "Wayne"));
            Employees.Add(new Person(4, "Bruce", "Banner"));
        }
    }
}
