﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method_Design_Pattern
{
    public class IglooHouseBuilder : IHouseBuilder
    {
        private House house;

        public IglooHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildBasement()
        {
            house.SetBasement("Ice Bars");
        }

        public void BuildStructure()
        {
            house.SetStructure("Ice Blocks");
        }

        public void BuildRoof()
        {
            house.SetRoof("Ice Dome");
        }

        public void BuildInterior()
        {
            house.SetInterior("Ice Carvings");
        }

        public House GetHouse()
        {
            return house;
        }
    }
}
