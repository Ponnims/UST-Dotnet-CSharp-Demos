using System;
using System.Collections.Generic;
using System.Text;

namespace DIDemo
{

    public class Switch
    {
        Light lightobj = new Light();

        public void SwitchOn()
        {
            Console.WriteLine("Switch is on");
            lightobj.On();
        }
        public void SwitchOff()
        {
            Console.WriteLine("Switch is off");
            lightobj.Off();
        }
    }

    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }
        public void Off()
        {
            Console.WriteLine("Light is off");
        }

        public class Fan
        {
            public void On()
            {
                Console.WriteLine("Fan is on");
            }
            public void Off()
            {
                Console.WriteLine("Fan is off");
            }

        }
        internal class DependancyInjDemo
        {
            static void Main(string[] args)
            {
                Switch switchobj = new Switch();
                switchobj.SwitchOn();
                switchobj.SwitchOff();
            }
        }
    }
}
