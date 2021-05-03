using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.OOP_Pillars
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class HomeAppliance
    {
        public readonly string _name;
        public readonly int _voltage;

        protected HomeAppliance(string name, int voltage)
        {
            _name = name;
            _voltage = voltage;
        }

        //Metodos padrões não podem ser sobrescritos e já tem seu comportamento definido
        public void DefaultMethod()
        {

        }

        //Metodos abstratos deverão ser implementados na classe que herdar de "HomeAppliance"
        public abstract void TurnOn();
        public abstract void TurnOff();

        //Métodos com o modificador "virtual" são métodos que tem uma implementação/funcionamento definido,
        //mas pode ser sobrescrito pela classe que herdar de "HomeAppliance"
        public virtual void Test()
        {
            //Test appliance
        }
    }
}
