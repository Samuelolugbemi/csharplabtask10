using System;
using System.Collections.Generic;
namespace TaxationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            House firsthouse = new House("Ibadan", false, 50.0, 50000M);
            House secondhouse = new House("Ota", true, 20.0, 25000M);
            House thirdhouse = new House("Jos", false, 45.0, 150000M);
            Bus firstbus = new Bus(45, 600, 8000M);
            Bus secondbus = new Bus(50, 293, 6000M);
            Bus thirdbus = new Bus(52, 396, 7000M);
            

            List<ITaxable> taxables = new List<ITaxable>(){firsthouse, secondhouse, thirdhouse, firstbus, secondbus, thirdbus};

            foreach (ITaxable item in taxables)
            {if(item is House)
                {
                Console.WriteLine($"House Taxation Value: {item.TaxValue():c}");
                }
                else{
                  Console.WriteLine($"Bus Taxation Value: {item.TaxValue():c}");   
                }
               
            }
        }
    }
}
