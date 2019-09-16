using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public struct Person
    {
        public string Name;
        public string LastName { get; set; }
        public int? BirthDate { get; set; }

        public int GetAge{get; set;}
        


    }
}
