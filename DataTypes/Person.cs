using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Person
    {
        public string Name;
        public string LastName { get; set; }
        public int BirthDate { get; set; }
        public Person()
        {
            BirthDate = 1950;
        }
        public int GetAge()
        {
            return DateTime.Today.Year - BirthDate;
        }


    }
}
