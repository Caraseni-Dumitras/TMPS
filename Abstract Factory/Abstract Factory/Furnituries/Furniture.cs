using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Furnituries
{
    abstract class Furniture
    {
        public int Price { get; set; }
        public abstract void Furniture_Info();
        
    }
}
