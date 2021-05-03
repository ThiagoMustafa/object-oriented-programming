using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.OOP_Pillars
{
    public class AutomationCoffe
    {
        public void PourCoffe()
        {
            var espresso = new CoffeMachine();
            espresso.TurnOn();
            espresso.PrepareCoffe();
            espresso.TurnOff();
        }
    }
}
