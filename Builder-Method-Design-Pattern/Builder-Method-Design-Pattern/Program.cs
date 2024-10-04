using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IHouseBuilder iglooBuilder = new IglooHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(iglooBuilder);

            engineer.ConstructHouse();

            House house = engineer.GetHouse();

            Console.WriteLine("Builder constructed: " + house);

            Console.ReadLine();
        }
    }
}
