using System;

namespace Espressab.EspressoMachineApi
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeBeverage outputFromCoffeMachine = new EspressoMachine().ToBeverage();

            /* Step 1: pseudo-code for creating a beverage
            CoffeeBeverage espresso = new EspressoMachine().AddWater(20).AddBeans(CoffeSorts.Robusta).ToBeverage();
            //espresso should be of type Espresso

            CoffeeBeverage latte = new EspressoMachine().AddWater(20).AddBeans(CoffeSorts.Arabica).AddMilk().ToBeverage();
            //latte should be of type Latte
             */

            /* Step 4: Unit tests */

            /* Step3:pseudo-code for validating a beverage
            CoffeeBeverage espresso = new EspressoMachine().AddWater(20).HeatWater().AddBeans(new Bean(){ 
                                AmountInG = 5,
                                Sort = CoffeSorts.Robusta, 
                                Grinding = Grinding.Fine}).Validate(b => b.Temperature > 80).ToBeverage();
            
            The validate is a method taking a lambda expression as input, if the expression fails should no beverage be returned

             */
        }
    }
}
