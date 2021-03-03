using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.PizzaTypes
{
    // Concrete component class
    class NormalPizza : Pizza
    {
        // The concrete component class has saves the size of the pizza
        private SizeType _sizeType;
        public NormalPizza(SizeType type)
        {
            _sizeType = type;

        }
        // The cost of the pizza depends on the size of it
        public override double GetPrice()
        {
            switch (_sizeType)
            {
                case SizeType.Lunch:
                    return 40.00;
                case SizeType.Regular:
                    return 60.00;
                case SizeType.Family:
                    return 90.00;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        // Base case of the recursive calls
        public override void GetDescription()
        {
            Console.WriteLine($"{GetSizeType()} Normal pizza with:");
        }
        public override SizeType GetSizeType()
        {
            return _sizeType;
        }
    }
}
