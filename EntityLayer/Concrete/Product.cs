using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double PurchasePrice { get; set; }
        public double SalesPrice { get; set; }
        public string ProductImage { get; set; }
        public int ProductStock { get; set; }
        public string ProductCode{ get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
