using AbstractFactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ConcreteProduct
{
    //The 'ProductB2' class
    class Scooty : IScooter
    {
        public string Name()
        {
            return "Scooty- Name";
        }
    }
}
