using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Car
    {
        public String name;
        public int speed;

        public Car(String name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }
        public int Brake(int braking)
        {
            this.speed -= braking;
            return this.speed;
        }
    }
}
