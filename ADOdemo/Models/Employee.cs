using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdemo.Models
{
    public class Employee
    {
         
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DId { get; set; }
    }

    public class Deparment
    {
        public int DId { get; set; }
        public string Dname { get; set; }
    }
}

