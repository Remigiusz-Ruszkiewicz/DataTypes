using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //bool isTrue = true;
            //isTrue = false;
            //Console.WriteLine(isTrue);
            //int a = 10;
            //a++;
            //decimal b = a;
            //int c = 2;
            //string d = "Roman";
            //int e = a / c;

            Person roman = new Person();
            roman.Name = "Roman";
            roman.LastName = "Nowak";
            roman.BirthDate = 2000;

            Person anna = roman;
            anna.Name = "Anna";
            anna.LastName = "Marek";

            int c = 10;
            int b = c;
            b = 5;
            Console.WriteLine(c);
            Console.WriteLine(b);

            //Console.WriteLine(roman.Name);
            //Console.WriteLine(roman.LastName);
            //Console.WriteLine(roman.GetAge());

            //Console.WriteLine(anna.Name);
            //Console.WriteLine(anna.LastName);
            //Console.WriteLine(anna.GetAge());
            Console.ReadLine();
        }
    }
}
