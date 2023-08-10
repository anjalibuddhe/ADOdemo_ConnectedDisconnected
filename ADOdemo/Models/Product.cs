using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADOdemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Prices { get; set; }
        public int Cid { get; set; }
    }

    public class Category
    {
        public int CId { get; set; }
        public string CName { get; set; }
    }
}
