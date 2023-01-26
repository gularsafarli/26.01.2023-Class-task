using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_class__task_8
{
    class Bicycle
    {
        public string Brand;
        public string Model;
        public double Millage;

        public void Drive(double km )
        {
            Millage += km;
        }
    }
}
