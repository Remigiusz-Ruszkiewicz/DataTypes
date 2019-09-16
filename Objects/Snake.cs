using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Snake : IAnimal
    {
        string IAnimal.Name { get; set; } = "snake";

        public int GetLegs()
        {
            return 0;
        }
    }
}
