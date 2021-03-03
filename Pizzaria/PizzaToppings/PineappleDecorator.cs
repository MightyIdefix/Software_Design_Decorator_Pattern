﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.PizzaToppings
{
    // Concrete decorator class inheriting from the abstract decorator class
    class PineappleDecorator : PizzaDecorator
    {
        // Set the wrapped pizza object as the one given in as a parameter in the constructor
        public PineappleDecorator(Pizza p) : base(p)
        { }
        
        public override double GetPrice()
        {
            if (this.GetSizeType() == Pizza.SizeType.Family)
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
            Console.WriteLine("Pineapple");
        }
    }
}