using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Person : IAnimal
    {
        public string Name { get; set; } = "Jan";

        public int GetLegs()
        {
            return 2;
        }
    }
}
