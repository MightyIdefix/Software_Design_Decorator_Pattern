using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Webpage used as a source for writing the code:
// https://www.dofactory.com/net/decorator-design-pattern
namespace Pizzaria
{
    // Abstract component class
    abstract class Pizza
    {
        public abstract void GetDescription();
        public abstract double GetPrice();
        public abstract SizeType GetSizeType();
        // Different sizes
        public enum SizeType
        { Lunch, Regular, Family }
    }
}
