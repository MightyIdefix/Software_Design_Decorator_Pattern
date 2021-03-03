using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.PizzaTypes
{
    // Concrete component class
    class CalzonePizza : Pizza
    {
        // The concrete component class has saves the size of the pizza
        private SizeType _sizeType;
        public CalzonePizza(SizeType type)
        {
            _sizeType = type;

        }
        // The cost of the pizza depends on the size of it
        public override double GetPrice()
        {
            switch (_sizeType)
            {
                case SizeType.Lunch:
                    return 50.00;
                case SizeType.Family:
                    return 70.00;
                case SizeType.Regular:
                    return 60.00;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        // Base case of the recursive calls
        public override void GetDescription()
        {
            Console.WriteLine($"{GetSizeType()} Calzone Pizza with: ");
        }

        public override SizeType GetSizeType()
        {
            return _sizeType;
        }
    }
}
