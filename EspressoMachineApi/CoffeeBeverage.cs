using System.Collections.Generic;

namespace Espressab.EspressoMachineApi
{
    public abstract class CoffeeBeverage
    {
        public string[] Ingredients { get; protected set; }
        public string CupType { get; protected set; }

        public int Temperature { get; protected set; }
        public double Price { get; protected set; }
    }

    public class Espresso : CoffeeBeverage
    {
        public Espresso()
        {
            Ingredients = new string[] { "water", "beans" };
        }
    }

    public class Latte : CoffeeBeverage
    {
        public Latte()
        {
            Ingredients = new string[] { "water", "beans", "milk" };
        }
    }
}