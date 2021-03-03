using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    // The decorator class inherits from the abstract component class
    abstract class PizzaDecorator : Pizza
    {
        // The decorator class also has an object from the abstract component class
        protected Pizza _pizza;

        // Constructor saving the abstract component object
        protected PizzaDecorator(Pizza p)
        {
            this._pizza = p;
        }

        // Recursive case handled in the wrapping objects
        public override void GetDescription()
        {
            _pizza.GetDescription();
        }

        public override double GetPrice()
        {
            return _pizza.GetPrice();
        }

        public override SizeType GetSizeType()
        {
            return _pizza.GetSizeType();
        }
    }
}
