using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Horse : Animal
    {
        public Horse() {
            Name = "xd";
        }

        public override string Name { get ; set ; }

        public override int GetLegs()
        {
            return 4;
        }
        public override string AnimalType()
        {
            string rezult = "XYZ";
            rezult = rezult + " " + base.AnimalType();
            return rezult;
        }
        public override void Sound()
        {
            Console.WriteLine("ihaha"); 
        }
    }
}
