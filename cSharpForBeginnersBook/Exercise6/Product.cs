using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Product
    {
        public String name;
        public Double price;
        public String category;
        public Product(String name, Double price, String category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }
        public Product(String name, String category)
        {
            this.name = name;
            this.category = category;
        }
    }
}
