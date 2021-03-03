using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.PizzaToppings
{
    // Concrete decorator class inheriting from the abstract decorator class
    class ChilliDecorator : PizzaDecorator
    {
        // Set the wrapped pizza object as the one given in as a parameter in the constructor
        public ChilliDecorator(Pizza p) : base(p)
        { }
        public override double GetPrice()
        {
            if (GetSizeType() == Pizza.SizeType.Family)
            {
                return _pizza.GetPrice() + 10;
            }
            else
            {
                return _pizza.GetPrice() + 5;
            }
        }
        public override void GetDescription()
        {
            _pizza.GetDescription();
            Console.WriteLine("Chili");
        }
    }
}
