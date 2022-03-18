using AbstractFactory.Furnituries;
using AbstractFactory.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal interface IFactoryProduct
    {
        Furniture CreateFurniture();
        Style CreateStyle();
    }
}
