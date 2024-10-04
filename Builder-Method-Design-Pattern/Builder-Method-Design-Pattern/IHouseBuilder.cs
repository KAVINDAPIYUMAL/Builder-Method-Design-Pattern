using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method_Design_Pattern
{
    public interface IHouseBuilder
    {
        void BuildBasement();
        void BuildStructure();
        void BuildRoof();
        void BuildInterior();
        House GetHouse();
    }
}
