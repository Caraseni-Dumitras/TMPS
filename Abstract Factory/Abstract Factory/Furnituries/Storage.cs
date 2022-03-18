using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Furnituries
{
    internal class Storage : Furniture
    {
        public Storage()
        {
            Price = 1000;
        }

        public override void Furniture_Info()
        {
            Console.WriteLine($"Storeage price is {Price}!");
        }
    }
}
