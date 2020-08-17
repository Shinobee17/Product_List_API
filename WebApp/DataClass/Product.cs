using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.DataClass
{
    public class Product
    {
        public int? Pid;
        public String Products;
        
        [NonSerialized]
        public string Category;

        public Product(int Pid, String Products, string Category)
        {
            this.Pid = Pid;
            this.Products = Products;
            
            this.Category = Category;
        }
    }
}
