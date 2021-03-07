using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espressab.EspressoMachineApi
{
    public class EspressoMachine : IEspressoMachine
    {
        // TODO: Add methods which is chainable, for adding ingredients to the 
        /*
         public I
         */

        public CoffeeBeverage ToBeverage()
        {
            // This methods should evaulate all input taken to the API and return a beverage object of the right kind
            // If the input is just water, the output is the-water
            // If the input is both water and coffeebeens, the output is espresso
            throw new NotImplementedException();
        }
    }
}
