using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method_Design_Pattern
{
    public class CivilEngineer
    {
        private IHouseBuilder houseBuilder;

        public CivilEngineer(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public House GetHouse()
        {
            return houseBuilder.GetHouse();
        }

        public void ConstructHouse()
        {
            houseBuilder.BuildBasement();
            houseBuilder.BuildStructure();
            houseBuilder.BuildRoof();
            houseBuilder.BuildInterior();
        }
    }
}
