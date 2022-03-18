using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Furnituries
{
    internal class Tables: Furniture
    {
        public Tables()
        {
            Price = 750;
        }

        public override void Furniture_Info()
        {
            Console.WriteLine($"Table price is {Price}!");
        }
    }
}
