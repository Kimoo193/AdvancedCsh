using Advanced_Csh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csh
{
    public class Car : IVehicle,IDrivable
    {
        private int gasoline;

        public Car(int A)
        {
            gasoline = A;
        }

        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("Out of gasoline. Cannot drive.");
            }
        }

        public bool Refuel(int amount)
        {
            if (amount > 0)
            {
                gasoline += amount;
                return true;
            }
            return false;
        }
        public void Move()
        {
            Console.WriteLine("Car is moving.");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating.");
        }
    }

}
