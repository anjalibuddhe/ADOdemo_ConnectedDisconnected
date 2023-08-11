using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdemo.Models
{
    public class Student
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }

            public int Age { get; set; }
            public int Bid { get; set; }
    }

        public class Branch
        {
            public int BId { get; set; }
            public string BName { get; set; }
        }
 }

