using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.PizzaToppings
{
    // Concrete decorator class inheriting from the abstract decorator class
    class BellPepperDecorator : PizzaDecorator
    {
        // Set the wrapped pizza object as the one given in as a parameter in the constructor
        public BellPepperDecorator(Pizza p) : base(p)
        { }
        // The price of a topping depends on the size of the pizza
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
            Console.WriteLine("Bell pepper");
        }
    }
}
