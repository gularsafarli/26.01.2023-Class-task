using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_class__task_8
{
    class Product
    {
        public string Name;
        public int Price;

        public Product(string name, int Price)
        {
            this.Name = name;
            this.Price = Price;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name+" "+Price+" ");
        }
    }
}
