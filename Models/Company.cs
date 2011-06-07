using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableEditable.Models
{
    public class Company
    {
        static int nextID = 17;

        public Company()
        {
            ID = nextID++;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
    }

    public class Town
    {
        static int nextID = 5;
        public Town()
        {
            ID = nextID++;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}