using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.PizzaToppings;
using Pizzaria.PizzaTypes;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the pizza object
            Pizza pizza = null;
            // Creating two bools used to ensure user doesn't give bad input
            bool test1 = false;
            bool test2 = false;
            while (!test1 && !test2)
            {
                test1 = false;
                test2 = false;
                Console.WriteLine("Choose type of pizza: Calzone (c), deep pan (d) or regular pizza (r)");
                string in1 = Console.ReadLine();

                Console.WriteLine("Choose size of pizza: Lunch (l), regular (r) or family (f)");
                string in2 = Console.ReadLine();

                if (in1 == "c")
                {
                    if (in2 == "l")
                    {
                        pizza = new CalzonePizza(Pizza.SizeType.Lunch);
                        test1 = true;
                        test2 = true;
                    }
                    else if (in2 == "r")
                    {
                        pizza = new CalzonePizza(Pizza.SizeType.Regular);
                        test1 = true;
                        test2 = true;
                    }
                    else if (in2 == "f")
                    {
                        pizza = new CalzonePizza(Pizza.SizeType.Family);
                        test1 = true;
                        test2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for size - try again!");
                    }
                }
                else if (in1 == "d")
                {
                    if (in2 == "l")
                    {
                        pizza = new DeepPanPizza(Pizza.SizeType.Lunch);
                        test1 = true;
                        test2 = true;
                    }
                    else if (in2 == "r")
                    {
                        pizza = new DeepPanPizza(Pizza.SizeType.Regular);
                        test1 = true;
                        test2 = true;
                    }
                    else if (in2 == "f")
                    {
                        pizza = new DeepPanPizza(Pizza.SizeType.Family);
                        test1 = true;
                        test2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for size - try again!");
                    }
                }
                else if (in1 == "r")
                {
                    if (in2 == "l")
                    {
                        pizza = new NormalPizza(Pizza.SizeType.Lunch);
                        test1 = true;
                        test2 = true;
                    }
                    else if (in2 == "r")
                    {
                        pizza = new NormalPizza(Pizza.SizeType.Regular);
                        test1 = true;
                        test2 = true;
                    }
                    else if (in2 == "f")
                    {
                        pizza = new NormalPizza(Pizza.SizeType.Family);
                        test1 = true;
                        test2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for size - try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for pizza type - try again!");
                }
            }

            test1 = false;
            while (!test1)
            {
                Console.WriteLine("Pick topping: Bell pepper (1), cheese (2), chili (3), dressing (4), garlic (5), ham (6), kebab (7), lettuce (8), onion (9), pepperoni (10) or pineapple (11)");
                switch (Console.ReadLine())
                {
                    case "1":
                        pizza = new BellPepperDecorator(pizza);
                        test1 = true;
                        break;
                    case "2":
                        pizza = new CheeseDecorator(pizza);
                        test1 = true;
                        break;
                    case "3":
                        pizza = new ChilliDecorator(pizza);
                        test1 = true;
                        break;
                    case "4":
                        pizza = new DressingDecorator(pizza);
                        test1 = true;
                        break;
                    case "5":
                        pizza = new GarlicDecorator(pizza);
                        test1 = true;
                        break;
                    case "6":
                        pizza = new HamDecorator(pizza);
                        test1 = true;
                        break;
                    case "7":
                        pizza = new KebabDecorator(pizza);
                        test1 = true;
                        break;
                    case "8":
                        pizza = new LettuceDecorator(pizza);
                        test1 = true;
                        break;
                    case "9":
                        pizza = new OnionDecorator(pizza);
                        test1 = true;
                        break;
                    case "10":
                        pizza = new PepperoniDecorator(pizza);
                        test1 = true;
                        break;
                    case "11":
                        pizza = new PineappleDecorator(pizza);
                        test1 = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input for topping");
                        break;
                }
            }

            test2 = false;
            while (!test2)
            {
                Console.WriteLine("Pick another topping: Bell pepper (1), cheese (2), chili (3), dressing (4), garlic (5), ham (6), kebab (7), lettuce (8), onion (9), pepperoni (10) or pineapple (11)");
                switch (Console.ReadLine())
                {
                    case "1":
                        pizza = new BellPepperDecorator(pizza);
                        test2 = true;
                        break;
                    case "2":
                        pizza = new CheeseDecorator(pizza);
                        test2 = true;
                        break;
                    case "3":
                        pizza = new ChilliDecorator(pizza);
                        test2 = true;
                        break;
                    case "4":
                        pizza = new DressingDecorator(pizza);
                        test2 = true;
                        break;
                    case "5":
                        pizza = new GarlicDecorator(pizza);
                        test2 = true;
                        break;
                    case "6":
                        pizza = new HamDecorator(pizza);
                        test2 = true;
                        break;
                    case "7":
                        pizza = new KebabDecorator(pizza);
                        test2 = true;
                        break;
                    case "8":
                        pizza = new LettuceDecorator(pizza);
                        test2 = true;
                        break;
                    case "9":
                        pizza = new OnionDecorator(pizza);
                        test2 = true;
                        break;
                    case "10":
                        pizza = new PepperoniDecorator(pizza);
                        test2 = true;
                        break;
                    case "11":
                        pizza = new PineappleDecorator(pizza);
                        test2 = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input for topping");
                        break;
                }
            }
            
            pizza.GetDescription();

            Console.WriteLine("Total price: " + pizza.GetPrice() + " kr\n");
        }
    }
}