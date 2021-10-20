using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int StockOnHand { get; set; }
        public Supplier ProductSupplier { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1}, on hand={2}", ProductId, Description, StockOnHand.ToString());
        }
        public string FullDetails()
        {
            return string.Format("{0}, {1}, Supplier={2}", ProductId, Description, ProductSupplier.Name);
        }
    }
}
