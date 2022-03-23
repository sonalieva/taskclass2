using System;
using System.Collections.Generic;
using System.Text;

namespace taskclass2
{
    class Product
    {
        public Product(int No, double Price, string name) 
        {
            this.No = No;
            this.Price = Price;
            this.Name = name;

        }
        public Product(int No, double Price, string name, int count) : this(No,Price,name)
        {
            this.Count = count;
        }
        public int No;
        public string Name;
        public int Count;
        public double Price;
    }
}
