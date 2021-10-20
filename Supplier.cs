using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Supplier(int id, string name, string address)
        {
            SupplierId = id;
            Name = name;
            Address = address;
        }
    }
}
