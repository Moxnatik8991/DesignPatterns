using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен!");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен...");
        }
    }
}
