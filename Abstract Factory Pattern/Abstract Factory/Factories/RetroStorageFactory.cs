using AbstractFactory.Factories;
using AbstractFactory.Furnituries;
using AbstractFactory.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class RetroStorageFactory : IFactoryProduct
    {
        public Furniture CreateFurniture()
        {
            return new Storage();
        }

        public Style CreateStyle()
        {
            return new Retro();
        }
    }
}
