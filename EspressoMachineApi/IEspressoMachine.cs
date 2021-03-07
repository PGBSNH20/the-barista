using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espressab.EspressoMachineApi
{
    public interface IEspressoMachine
    {
        CoffeeBeverage ToBeverage();
    }
}
