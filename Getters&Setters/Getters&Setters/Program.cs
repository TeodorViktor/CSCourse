using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.Name = "BMW";
            audi.Details();
            Console.ReadKey();
        }
    }
}
