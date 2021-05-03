using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.OOP_Pillars
{
    public class CoffeMachine : HomeAppliance
    {
        public CoffeMachine()
            :base("Default", 220)
        {

        }

        private static void HeatWater() { }
        private static void GrindingGrains() { }
        public void PrepareCoffe()
        {
            HeatWater();
            GrindingGrains();
        }

        public override void TurnOn()
        {
            //Check water container
        }
        public override void TurnOff()
        {
            //Cool heater
        }


    }
}
