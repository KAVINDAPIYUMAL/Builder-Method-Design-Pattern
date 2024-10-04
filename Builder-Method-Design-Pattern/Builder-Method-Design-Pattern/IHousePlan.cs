using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method_Design_Pattern
{
    public interface IHousePlan
    {
        void SetBasement(string basement);
        void SetStructure(string structure);
        void SetRoof(string roof);
        void SetInterior(string interior);
    }
}
